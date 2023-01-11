using DirectShowLib.DMO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team1_Project.model;

namespace Team1_Project.dao {
    internal class DaoOra {
        string ORA_ADDR =
           "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
           "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
           "(PORT=1521)))" +
           "(CONNECT_DATA=(SERVER=DEDICATED)" +
           "(SERVICE_NAME=XE)));" +
           "User Id=test;Password=1234;";

        OracleConnection conn;
        OracleCommand cmd;

        public DaoOra() {
            conn = new OracleConnection(ORA_ADDR);
            cmd = new OracleCommand();
            connectDB();
        }

        static DaoOra inst;

        public static DaoOra getInst() {
            if (inst == null) {
                inst = new DaoOra();
            }
            return inst;
        }


        ~DaoOra() {
            disconnectDB();
        }

        #region DB 연결,해제
        /// <summary>
        /// DB 연결
        /// </summary>
        public void connectDB() {
            try {
                conn.Open(); // db 접속
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("접속에러: " + e.Message);
            }
        }
        /// <summary>
        /// DB 연결해제
        /// </summary>
        public void disconnectDB() {
            try {
                if (conn != null) {
                    conn.Close();
                    Console.WriteLine("오라클 해제 성공!");
                }
            }
            catch (OracleException e) {
                Console.WriteLine("종료 에러:" + e.Message);
            }
        }
        #endregion

        public int tableCount(string table) {

            int count = 1;

            string query = $"select * from {table}";

            Console.WriteLine(query);

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows) {
                while (dr.Read()) {
                    count++;
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않습니다");
            }
            return count;
        }



        //테이블에서 칼럼 데이터를 가져오기
        public List<string> tableGetColumn(string column , string table) {

            string query = $"select {column} from {table}";

            Console.WriteLine(query);

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            List<string> comList = new List<string>();

            if (dr.HasRows) {
                while (dr.Read()) {
                    Console.WriteLine($"이름 : {dr[column]}");
                    comList.Add(dr[column].ToString());
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않습니다");

            }
            Console.WriteLine(comList.Count);

            return comList;
        }

        public Image tableGetimage(string num, string imageTable) {

            Image img = null;

            cmd.Connection = conn;
            cmd.CommandText= $"select Imgdata from {imageTable} where filename = '{num}'";
            cmd.CommandType= CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows) {
                while (dr.Read()) {
                    byte[] byteData = (byte[])dr["imgdata"];
                    if (byteData.Length > 0) {
                        MemoryStream ms = new MemoryStream(byteData);
                        img = Image.FromStream(ms);
                    }
                    else {
                        img = null;
                    }
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않음!");
                MessageBox.Show("데이터가 존재하지 않음!");
            }
            return img;

        }

        public string tableGetColumn(string column, string table, string whereCom, string whereVal) {

            string query = $"select {column} from {table} where {whereCom} = '{whereVal}'";

            Console.WriteLine(query);

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            string getColumn = string.Empty;

            if (dr.HasRows) {
                while (dr.Read()) {
                    //Console.WriteLine($"이름 : {dr[column]}");
                    getColumn = dr[column].ToString();
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않습니다");

            }

            Console.WriteLine(getColumn);

            return getColumn;
        }


        #region 도서 BOOK TABLE

        public List<Book> bookShow() {
            string query = "select * from book";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Book> bookList = new List<Book>();
            if (dr.HasRows) {
                while (dr.Read()) {
                    bookList.Add(new Book(
                        dr["bnum"].ToString(),
                        dr["bname"].ToString(),
                        dr["baut"].ToString(),
                        dr["bpub"].ToString(),
                        dr["byear"].ToString(),
                        dr["bcat"].ToString(),
                        dr["bdiv"].ToString(),
                        dr["bdcount"].ToString()));
                }
            }
            else {
                Console.WriteLine("도서 정보가 존재하지 않음");
            }
            dr.Close();
            return bookList;
        }

        public List<Book> bookSearch(string searchTag, string searchText) {
            List<Book> searchList = new List<Book>();
            try {
                string tag = null;
                if (searchTag == "도서번호") {
                    tag = "bnum";
                }
                else if (searchTag == "도서제목") {
                    tag = "bname";
                }
                else if (searchTag == "저자") {
                    tag = "baut";
                }
                else if (searchTag == "카테고리") {
                    tag = "bcat";
                }
                else if (searchTag == "구분") {
                    tag = "bdiv";
                }
                string sql = $"select * from book where {tag} like '%{searchText}%'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                OracleDataReader dr = cmd.ExecuteReader();

                Console.WriteLine("데이터 검색 성공!");

                if (dr.HasRows) {
                    while (dr.Read()) {
                        searchList.Add(new Book(
                            dr["bnum"].ToString(),
                            dr["bname"].ToString(),
                            dr["baut"].ToString(),
                            dr["bpub"].ToString(),
                            dr["byear"].ToString(),
                            dr["bcat"].ToString(),
                            dr["bdiv"].ToString(),
                            dr["bdcount"].ToString()));
                    }
                }
                else {
                    Console.WriteLine("데이터가 존재하지 않음!");
                }
                dr.Close();

            }
            catch (OracleException e) {
                Console.WriteLine("데이터 검색 에러 :" + e.Message);
                cmd.Transaction.Rollback();
            }
            return searchList;
        }


        #endregion

        #region 강좌 LECTURE TABLE

        //Lecture 테이블에 넣기
        public void insertData(Lecture lec) {
            try {
                string insert_sql = "insert into lecture VALUES" +
                    $"('{lec.LNum}', '{lec.LName}', '{lec.LLoc}', " +
                    $"'{lec.LTar}', '{lec.LPer}', '{lec.LTime}', '{lec.LDay}', '{lec.LTeacher}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = insert_sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 추가 성공!");
                cmd.Transaction.Commit();
            }

            catch (Exception e) {
                Console.WriteLine("데이터 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }

        }

        public List<Lecture> lectureShow() {
            string query = "select * from lecture";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Lecture> lecList = new List<Lecture>();
            if (dr.HasRows) {
                while (dr.Read()) {

                    //test
                    Console.WriteLine($"번호:{dr["lnum"]}");
                    Console.WriteLine($"이름:{dr["lname"]}");
                    Console.WriteLine($"강의실:{dr["lloc"]}");
                    Console.WriteLine($"연령:{dr["ltar"]}");
                    Console.WriteLine($"기간:{dr["lper"]}");
                    Console.WriteLine($"시간:{dr["ltime"]}");
                    Console.WriteLine($"요일:{dr["lday"]}");

                    lecList.Add(new Lecture(
                        dr["lnum"].ToString(),
                        dr["lname"].ToString(),
                        dr["lloc"].ToString(),
                        dr["ltar"].ToString(),
                        dr["lper"].ToString(),
                        dr["ltime"].ToString(),
                        dr["lday"].ToString(),
                        dr["ltnum"].ToString()
                        ));
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();

            return lecList;
        }

        public void lectureImgImg(string name, string path) {
            string sql = $"insert into lectureImg " +
                $"values ('{name}', :image)";
            try {
                cmd.Connection = conn;
                cmd.Transaction = conn.BeginTransaction();
                cmd.CommandText = sql;
                FileStream fs =
                    new FileStream(path, FileMode.Open,
                        FileAccess.Read);
                byte[] buffer = new byte[fs.Length - 1];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                OracleParameter op =
                    new OracleParameter();
                op.ParameterName = ":image";
                op.OracleDbType = OracleDbType.Blob;
                op.Direction = ParameterDirection.Input;
                op.Size = buffer.Length;
                op.Value = buffer;
                cmd.Parameters.Add(op);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Transaction.Commit();
                Console.WriteLine("이미지 추가 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("이미지 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        #endregion



    }
}
