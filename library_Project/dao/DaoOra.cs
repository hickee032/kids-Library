using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library_Project.model;

namespace library_Project.dao {
    internal class DaoOra {
        string ORA_ADDR =
           "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
           "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
           "(PORT=1521)))" +
           "(CONNECT_DATA=(SERVER=DEDICATED)" +
           "(SERVICE_NAME=XE)));" +
           "User Id=test;Password=1234;";
        // 오라클 접속, sql명령어 객체 생성
        OracleConnection conn;
        OracleCommand cmd;

        static DaoOra inst;

        public static DaoOra getInst() {
            if (inst == null) {
                inst = new DaoOra();
            }
            return inst;
        }
        public DaoOra() {
            conn = new OracleConnection(ORA_ADDR);
            cmd = new OracleCommand();
            connectDB();
        }

        ~DaoOra() {
            disconnectDB();
        }

        public void connectDB() {
            // try ~ catch : 객체지향 프로그래밍에서 예외처리
            try {
                conn.Open(); // db 접속
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("접속에러: " + e.Message);
            }
        }

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

        public List<Lecture> dataShow() {
            string query = "select * from lecture";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Lecture> memList = new List<Lecture>();
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

                    memList.Add(new Lecture(
                        dr["lnum"].ToString(),
                        dr["lname"].ToString(),
                        dr["lloc"].ToString(),
                        dr["ltar"].ToString(),
                        dr["lper"].ToString(),
                        dr["ltime"].ToString(),
                        dr["lday"].ToString()
                        ));
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return memList;
        }


    }
}
