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
using System.Text.RegularExpressions;
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
           "User Id=team1;Password=1234;";

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


        #region 테이블에서 칼럼 데이터를 가져오기 (오버로딩)
        

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

        public List<string> tableGetColumn(string column, string table, string whereCom) {

            List<string> comList = new List<string>();

            string query = $"select {column} from {table} where {whereCom} != 0 and rownum<=2 order by {whereCom} desc";

            Console.WriteLine(query);

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            string getColumn = string.Empty;

            if (dr.HasRows) {
                while (dr.Read()) {

                    comList.Add(dr[column].ToString());
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않습니다");

            }

            Console.WriteLine(getColumn);

            return comList;
        }

        public List<string> tableGetColumn(string column, string table,int count, string whereCom) {

            List<string> comList = new List<string>();

            string query = $"select {column} from {table} where rownum <={count} order by {whereCom} desc";

            Console.WriteLine(query);

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            string getColumn = string.Empty;

            if (dr.HasRows) {
                while (dr.Read()) {

                    comList.Add(dr[column].ToString());
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않습니다");

            }

            Console.WriteLine(getColumn);

            return comList;
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

        public Image tableGetimage(string imageTable) {

            Image img = null;

            cmd.Connection = conn;
            cmd.CommandText = $"select imgdata from {imageTable}";
            cmd.CommandType = CommandType.Text;
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

        public Image tableGetimage(string num, string imageTable) {

            Image img = null;

            cmd.Connection = conn;
            cmd.CommandText= $"select imgdata from {imageTable} where filename = '{num}'";
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

        public Image tableGetimage( string imgCalm ,string imageTable,string whereVal) {

            Image img = null;

            cmd.Connection = conn;
            cmd.CommandText = $"select {imgCalm} from {imageTable} where bnum = '{whereVal}'";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows) {
                while (dr.Read()) {
                    byte[] byteData = (byte[])dr["bdimg"];
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
               
            }
            return img;
        }

        #endregion


        #region 회원 CUSTOMER TABLE

        //회원정보 보여주기
        public List<Customer> showProfile(string cnum) {
            string query = $"select * from Customer where cnum = '{cnum}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Customer> cusList = new List<Customer>();
            if (dr.HasRows) {
                while (dr.Read()) {
                    Console.WriteLine($"회원번호: {dr["cnum"]}");
                    Console.WriteLine($"이름: {dr["cname"]}");
                    Console.WriteLine($"나이: {dr["cage"]}");
                    Console.WriteLine($"성별: {dr["cgen"]}");
                    Console.WriteLine($"연락처: {dr["ctel"]}");
                    Console.WriteLine($"마지막접속일: {dr["clast"]}");
                    Console.WriteLine($"회원타입: {dr["ctype"]}");
                    Console.WriteLine($"부모번호: {dr["pnum"]}");
                    Console.WriteLine($"교사번호: {dr["tnum"]}");
                    Console.WriteLine($"소속: {dr["cschool"]}");
                    Console.WriteLine($"관심사: {dr["cint"]}");
                    Console.WriteLine($"수강강좌: {dr["lnum"]}");
                    Console.WriteLine("-------------------");
                    cusList.Add(new Customer(
                        dr["cnum"].ToString(),
                        dr["cpw"].ToString(),
                        dr["cname"].ToString(),
                        dr["cage"].ToString(),
                        dr["cgen"].ToString(),
                        dr["ctel"].ToString(),
                        dr["clast"].ToString(),
                        dr["ctype"].ToString(),
                        dr["pnum"].ToString(),
                        dr["tnum"].ToString(),
                        dr["cschool"].ToString(),
                        dr["cint"].ToString(),
                        dr["lnum"].ToString()));
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return cusList;
        }
        //회원정보 입력
        public void insertProfile(Customer cus) {
            try {
                string sql = $"insert into customer values ('{cus.Cnum}', '{cus.Cpw}', '{cus.Cname}', '{cus.Cage}', '{cus.Cgen}', '{cus.Ctel}', '{cus.Clast}', '{cus.Ctype}', '{cus.Pnum}', '{cus.Tnum}', '{cus.Cschool}', '{cus.Cint}', '{cus.Lnum}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine(" 데이터 추가 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine(" 데이터 추가 오류: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public void insertProfile(string cnum, string cpw, string cname, string cage, string cgen, string ctel, string ctype, string pnum, string cschool, string cint) {
            try {

                string sql = $"insert into Customer values ('{cnum}', '{cpw}', '{cname}', '{cage}', '{cgen}', '{ctel}', '{ctype}', '{pnum}', '{cschool}', '{cint}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine(" 데이터 추가 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine(" 데이터 추가 오류: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        //회원정보 찾기
        public string searchProfile(string cnum1) {
            string query = $"select * from customer where cnum = '{cnum1}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            //List<Customer> cusList = new List<Customer>();
            if (dr.HasRows) {
                Console.WriteLine("데이터가 존재!");
                cnum1 = "0";
            }
            else {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return cnum1;
        }


        //회원정보 수정 업데이트
        public List<Customer> updateProfile(string cnum, Customer cus) {
            try {
                string sql = "update Customer set " +
                    $"cnum = '{cus.Cnum}', cpw = '{cus.Cpw}', cname = '{cus.Cname}', cage = '{cus.Cage}', cgen = '{cus.Cgen}', ctel = '{cus.Ctel}', ctype = '{cus.Ctype}'" +
                    $", pnum = '{cus.Pnum}', cschool = '{cus.Cschool}', cint = '{cus.Cint}'" +
                    $" where cnum ='{cnum}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 업데이트 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("데이터 업데이트 오류: " + e.Message);
                cmd.Transaction.Rollback();
            }
            List<Customer> list = showProfile(cnum);
            return list;
        }

        public List<Customer> customerDataShow() {
            string query = "select * from customer";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Customer> customerList = new List<Customer>();
            if (dr.HasRows) {
                while (dr.Read()) {
                    customerList.Add(new Customer(
                        dr["cnum"].ToString(),
                        dr["cname"].ToString(),
                        dr["cage"].ToString(),
                        dr["cgen"].ToString(),
                        dr["ctel"].ToString(),
                        dr["clast"].ToString(),
                        dr["ctype"].ToString(),
                        dr["pnum"].ToString(),
                        dr["tnum"].ToString(),
                        dr["cschool"].ToString(),
                        dr["cint"].ToString(),
                        dr["lnum"].ToString()));
                }
            }
            else {
                Console.WriteLine("회원 정보가 존재하지 않음");
            }
            dr.Close();
            return customerList;
        }

        public List<Customer> customerDataType(string type) {
            string query = $"select * from customer where ctype LIKE '{type}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Customer> customerList = new List<Customer>();
            if (dr.HasRows) {
                while (dr.Read()) {
                    customerList.Add(new Customer(
                        dr["cnum"].ToString(),
                        dr["cname"].ToString(),
                        dr["cage"].ToString(),
                        dr["cgen"].ToString(),
                        dr["ctel"].ToString(),
                        dr["clast"].ToString(),
                        dr["ctype"].ToString(),
                        dr["pnum"].ToString(),
                        dr["tnum"].ToString(),
                        dr["cschool"].ToString(),
                        dr["cint"].ToString(),
                        dr["lnum"].ToString()));
                }
            }
            else {
                Console.WriteLine("회원 정보가 존재하지 않음");
            }
            dr.Close();
            return customerList;
        }

        public List<Customer> customerSearch(string searchTag, string searchText) {
            List<Customer> customerList = new List<Customer>();
            try {
                string tag = null;
                if (searchTag == "회원번호") {
                    tag = "cnum";
                }
                else if (searchTag == "이름") {
                    tag = "cname";
                }
                else if (searchTag == "연락처") {
                    tag = "ctel";
                }
                else if (searchTag == "회원번호") {
                    tag = "pnum";
                }
                else if (searchTag == "회원번호") {
                    tag = "tnum";
                }
                else if (searchTag == "소속") {
                    tag = "cschool";
                }

                string sql = $"select * from customer where {tag} like '%{searchText}%'";
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
                        customerList.Add(new Customer(
                        dr["cnum"].ToString(),
                        dr["cname"].ToString(),
                        dr["cage"].ToString(),
                        dr["cgen"].ToString(),
                        dr["ctel"].ToString(),
                        dr["clast"].ToString(),
                        dr["ctype"].ToString(),
                        dr["pnum"].ToString(),
                        dr["tnum"].ToString(),
                        dr["cschool"].ToString(),
                        dr["cint"].ToString(),
                        dr["lnum"].ToString()));
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
            return customerList;
        }

        public List<Customer> customerDelete(string cname, Customer cst) {
            try {
                string sql = $"delete from customer where cname = '{cname}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("회원정보 삭제 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("회원정보 삭제 오류 :" + e.Message);
                cmd.Transaction.Rollback();
            }
            List<Customer> list = customerDataShow();
            return list;
        }

        public List<Customer> customerUpdate(string cname, Customer cst) {
            try {
                string sql = "update customer set " +
                    $"Cnum='{cst.Cnum}', " +
                    $"Cname='{cst.Cname}', " +
                    $"Cage='{cst.Cage}', " +
                    $"Cgen='{cst.Cgen}', " +
                    $"Ctel='{cst.Ctel}', " +
                    $"Clast='{cst.Clast}',  " +
                    $"Ctype='{cst.Ctype}', " +
                    $"Pnum='{cst.Pnum}', " +
                    $"Tnum='{cst.Tnum}', " +
                    $"Cschool='{cst.Cschool}', " +
                    $"Cint='{cst.Cint}', " +
                    $"Lnum='{cst.Lnum}' " +
                    $"where cname='{cname}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("회원정보 수정 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("회원정보 수정 에러:" + e.Message);
                cmd.Transaction.Rollback();
            }
            List<Customer> list = customerDataShow();
            return list;
        }

        #endregion

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
                        dr["bnob"].ToString(),
                        dr["bnobob"].ToString(),
                        dr["bdcount"].ToString()));
                }
            }
            else {
                Console.WriteLine("도서 정보가 존재하지 않음");
            }
            dr.Close();
            return bookList;
        }

        public List<Book> searchBook(string searchTag, string searchText) {
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
                else {
                    MessageBox.Show("검색항목을 선택해주세요");
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
                            dr["bnob"].ToString(),
                            dr["bnobob"].ToString(),
                            dr["bdcount"].ToString()));
                    }
                }
                else {
                    Console.WriteLine("searchData 오류!");
                }
                dr.Close();

            }
            catch (OracleException e) {
                Console.WriteLine("데이터 검색 에러 :" + e.Message);
                Console.WriteLine("검색 정보가 누락되어있습니다.");
                cmd.Transaction.Rollback();
            }
            return searchList;
        }

        public List<Book> deleteBook(string bname, Book bk) {
            try {
                string sql = $"delete from BOOK where bname = '{bname}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("deleteBook 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("deleteBook 에러 :" + e.Message);
                cmd.Transaction.Rollback();
            }
            List<Book> list = bookShow();
            return list;

        }

        public void bookGetImg(PictureBox pic, string name) {
            cmd.Connection = conn;
            cmd.CommandText = $"select * from book where bname='{name}'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            try {
                if (dr.HasRows) {
                    while (dr.Read()) {
                        byte[] byteData = (byte[])dr["bdimg"]; // book 테이블 bdimg 칼럼  null 이면 예외처리 오류 발생함.
                        if (byteData.Length > 0) {
                            MemoryStream ms = new MemoryStream(byteData);
                            pic.Image = Image.FromStream(ms);
                        }
                        else {
                            pic.Image = null;
                        }
                    }
                }
                else {
                    Console.WriteLine("getImg 이미지가 존재하지 않음!");
                }
                dr.Close();
            }
            catch (OracleException e) {
                Console.WriteLine("getImg 오류 발생 :" + e.Message);
                cmd.Transaction.Rollback();
            }

        }

        //추천

        public void insertRecommend(Recommend recommend) {
            try {
                string sql = "insert into recommendedbooks values " +
                    $"('{recommend.Tnum}', '{recommend.Bnum}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("추천 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("추천 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        //----------------------------------------

        #endregion

        public List<Book> updateBook(string bname, Book bk) {
            try {
                string sql = "UPDATE book SET " +
                    $"Bnum='{bk.Bnum}', " +
                    $"Bname='{bk.Bname}', " +
                    $"Baut='{bk.Baut}', " +
                    $"Bpub='{bk.Bpub}', " +
                    $"Byear='{bk.Byear}', " +
                    $"Bcat='{bk.Bcat}',  " +
                    $"Bdiv='{bk.Bdiv}', " +
                    $"Bnob='{bk.Bnob}', " +
                    $"Bdimg= :image " +
                    $"WHERE bname='{bname}'";
                cmd.Connection = conn;
                cmd.Transaction = conn.BeginTransaction();
                cmd.CommandText = sql;

                FileStream fs = new FileStream(bk.Path, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[fs.Length - 1];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                OracleParameter op = new OracleParameter();
                op.ParameterName = ":image";
                op.OracleDbType = OracleDbType.Blob;
                op.Direction = ParameterDirection.Input;
                op.Size = buffer.Length;
                op.Value = buffer;
                cmd.Parameters.Add(op);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Transaction.Commit();
                Console.WriteLine("updateBook 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("updateBook 오류 : " + e.Message);
                cmd.Transaction.Rollback();
            }
            List<Book> list = bookShow();
            return list;

        }


        public bool duplicationFind(string searchText) {
            bool found = false;
            List<Book> bookList = new List<Book>();
            try {
                string sql = $"select * from book where bname like '%{searchText}%'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows) {
                    // sql 업데이트문으로 bnob 증가 시키기.
                    Console.WriteLine("이미 등록된 책입니다. 장서 수를 추가합니다.");

                    //string sqlUpdate = $"UPDATE book SET bnob = bnob + 1 WHERE bname = '{searchText}'";
                    //Console.WriteLine("bnob 증가 성공! ");
                    found = true;
                }
                else {
                    Console.WriteLine("데이터가 존재하지 않음!");
                }
                dr.Close();
            }
            catch (OracleException e) {
                Console.WriteLine("중복 처리 에러 :" + e.Message);
                cmd.Transaction.Rollback();
            }
            return found;
        }

        public string AddBnob(string dbbname) {
            string query = $"select bnob from book where bname = '{dbbname}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            string returnbnob = string.Empty;
            if (dr.HasRows) {
                while (dr.Read()) {
                    string dbBnob = dr["bnob"].ToString();
                    int subdbBnob = int.Parse(dbBnob) + 1;
                    returnbnob = subdbBnob.ToString();
                }
            }
            else {
                Console.WriteLine("도서 정보가 존재하지 않음");
            }
            dr.Close();
            return returnbnob;
        }

        public void returnBnob(string dbbname, string dbbnob){
            try {
                string sql = $"update book set bnob = '{dbbnob}' " +
                    $"where bname = '{dbbname}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("총장서량 증가 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("총장서량 증가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public void insertBook(Book bk) {
            try {
                string sql = "insert into book values " +
                    $"('{bk.Bnum}', '{bk.Bname}', '{bk.Baut}', " +
                    $"'{bk.Bpub}', '{bk.Byear}', '{bk.Bcat}', " +
                    $"'{bk.Bdiv}','{bk.Bnob}','{bk.Bnobob}', '{bk.Bdcount}', :image)";
                cmd.Connection = conn;
                cmd.Transaction = conn.BeginTransaction();
                cmd.CommandText = sql;

                FileStream fs = new FileStream(bk.Path, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[fs.Length - 1];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                OracleParameter op = new OracleParameter();
                op.ParameterName = ":image";
                op.OracleDbType = OracleDbType.Blob;
                op.Direction = ParameterDirection.Input;
                op.Size = buffer.Length;
                op.Value = buffer;
                cmd.Parameters.Add(op);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Transaction.Commit();
                Console.WriteLine("insertBook2 성공!");
                Console.WriteLine("이미지 추가 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("insertBook2 오류 :" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public void bookImgSave(string name, string path) {

            string sql = $"insert into saveimg_t " +
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

        #region 대출 DAECHUL TABLE

        public string borrowBook() {
            string query = "select dnum from daechul order by dnum desc";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            string dnum = string.Empty;
            if (dr.HasRows) {
                if (dr.Read()) {
                    string receiveddnum = dr["dnum"].ToString();
                    string tempStr = Regex.Replace(receiveddnum, @"\D", "");

                    int rstint = int.Parse(tempStr);
                    dnum = "D" + (rstint + 1).ToString("0000.");
                }
            }
            else {
                dnum = "D0001";
            }
            dr.Close();
            return dnum;
        }

        public void insertDaechul(Daechul daechul) {
            try {
                string sql = "insert into daechul values " +
                    $"('{daechul.Dnum}', '{daechul.Cnum}', '{daechul.Bnum}', " +
                    $"'{daechul.Ddate}', '{daechul.Dreturn}', '{daechul.Dreturned}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("대출 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("대출 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public List<NoBook> addBnobobBdcount(string dbbnum) {
            string query = $"select bnum, bnobob, bdcount from book where bnum = '{dbbnum}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<NoBook> booknobobList = new List<NoBook>();
            if (dr.HasRows) {
                while (dr.Read()) {
                    string receiveBnobob = dr["bnobob"].ToString();
                    int sumReceiveBnobob = int.Parse(receiveBnobob) + 1;
                    string returnBnobob = sumReceiveBnobob.ToString();

                    string receiveBdcount = dr["bdcount"].ToString();
                    int sumReceiveBdcount = int.Parse(receiveBdcount) + 1;
                    string returnBdcount = sumReceiveBdcount.ToString();

                    booknobobList.Add(new NoBook(
                        dr["bnum"].ToString(),
                        returnBnobob,
                        returnBdcount));
                }
            }
            else {
                Console.WriteLine("도서 정보가 존재하지 않음");
            }
            dr.Close();
            return booknobobList;
        }

        public void updateBnobBdcount(List<NoBook> bnobobBdcount) {
            try {
                string sql = $"update book set bnobob = '{bnobobBdcount[0].Bnobob}', " +
                    $"bdcount = '{bnobobBdcount[0].Bdcount}' " +
                    $"where bnum = '{bnobobBdcount[0].Bnum}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("대출 횟수 추가 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("대출 횟수 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public List<DaechulBook> DaechulShow(string id) {

            string query = $"select d.bnum, bname, baut, ddate, dreturn, dnum " +
                "from daechul d inner join book b " +
                $"on d.bnum = b.bnum and cnum = '{id}' and dreturned is null " +
                "order by dreturn, dnum";

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<DaechulBook> DCBookList = new List<DaechulBook>();
            if (dr.HasRows) {
                while (dr.Read()) {
                    DCBookList.Add(new DaechulBook(
                        dr["bnum"].ToString(),
                        dr["bname"].ToString(),
                        dr["baut"].ToString(),
                        dr["ddate"].ToString(),
                        dr["dreturn"].ToString(),
                        dr["dnum"].ToString()));
                }
            }
            else {
                Console.WriteLine("대출 정보가 존재하지 않음");
            }
            dr.Close();
            return DCBookList;
        }

        public List<DaechulBook> DaechulSearch(string searchTag, string searchText , string id) {
            List<DaechulBook> searchList = new List<DaechulBook>();
            try {
                string tag = null;

                if (searchTag == "도서번호") {
                    tag = "b.bnum";
                }
                else if (searchTag == "도서제목") {
                    tag = "b.bname";
                }
                else if (searchTag == "저자") {
                    tag = "b.baut";
                }
                else if (searchTag == "대출일") {
                    tag = "d.ddate";
                }
                else if (searchTag == "반납예정일") {
                    tag = "d.dreturn";
                }
                else {
                    MessageBox.Show("검색항목을 선택해주세요");
                }
                /*오라클 select문 select d.bnum, bname, baut, ddate, dreturn, dnum 
                 * from daechul d inner join book b 
                 * on d.bnum = b.bnum and cnum = 'C0002' and dreturned is null
                 * and {tag} like '%{searchText}%' order by dreturn, dnum;*/
                string sql = $"select b.bnum, bname, baut, ddate, dreturn, dnum " +
                    $"from daechul d inner join book b " +
                    $"on d.bnum = b.bnum and cnum = '{id}' and dreturned is null " +
                    $"and {tag} like '%{searchText}%' order by dreturn, dnum";
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
                        searchList.Add(new DaechulBook(
                            dr["bnum"].ToString(),
                            dr["bname"].ToString(),
                            dr["baut"].ToString(),
                            dr["ddate"].ToString(),
                            dr["dreturn"].ToString(),
                            dr["dnum"].ToString()));
                    }
                }
                else {
                    Console.WriteLine("데이터가 존재하지 않음!");
                }
                dr.Close();

            }
            catch (OracleException e) {
                Console.WriteLine("데이터 검색 에러 :" + e.Message);
                Console.WriteLine("검색 정보가 누락되어있습니다.");
                cmd.Transaction.Rollback();
            }
            return searchList;
        }

        public void DaechulReturn(Daechul daechul) {
            try {
                string sql = $"update daechul set dreturned = '{daechul.Dreturned}' " +
                    $"where dnum = '{daechul.Dnum}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("반납 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("도서 반납 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public string SubBnobob(string dbbnum) {
            string query = $"select bnobob from book where bnum = '{dbbnum}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            string returnbnobob = string.Empty;
            if (dr.HasRows) {
                while (dr.Read()) {
                    string dbBnobob = dr["bnobob"].ToString();
                    int subdbBnobob = int.Parse(dbBnobob) - 1;
                    returnbnobob = subdbBnobob.ToString();
                }
            }
            else {
                Console.WriteLine("도서 정보가 존재하지 않음");
            }
            dr.Close();
            return returnbnobob;
        }

        public void returnBnobob(string dbbnum, string dbbnobob) {
            try {
                string sql = $"update book set bnobob = '{dbbnobob}' " +
                    $"where bnum = '{dbbnum}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("대여중인 장서량 감소 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("대여중인 장서량 감소 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
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
