using System.Collections;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Collections.Generic;
using AutoSclad;

namespace SecGak
{
    class DAL
    {
        
        //строка соеденения'
        string myConnectionString = @"Database="+ Program.database +";Data Source="+Program.datasource+";User Id="+Program.login+";Password="+Program.password+"";
            public ArrayList GetAllGroups() {
            ArrayList allGroups = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
              {
                try
                    {
                        myConnection.Open();
                        string CommandText = ("SELECT * FROM group1");
                        MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);                    
                        MySqlDataReader MyDataReader;
                        MyDataReader = myCommand.ExecuteReader();

                        if (MyDataReader.HasRows)
                            foreach (DbDataRecord result in MyDataReader)
                                allGroups.Add(result);
                        MyDataReader.Close();
                        return allGroups;
                    }
                catch (Exception ex)
                    {
                        return null;

                    }
                finally
                    {
                        myConnection.Close();
                    }
            }
        }


        //данные третьего протакола
        public ArrayList GetThreeProtocol(string id)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT distinct students.Sfio,students.gos_ocenka,secretar.name,secretar.dolzhnost , group1.Gname ,diplom.ocenka,diplom.name,diplom.nauch_rucov,diplom.recenzent,diplom.recenzent_dolzhnost, chairman.name , chairman.post,group1.id  FROM chairman,commission,diplom,group1,secretar,students where diplom.id = students.id_diplom and students.id = {0} and group1.id = students.idGroup" , Convert.ToInt32(id));


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        public ArrayList GetThreeProtocolCommission(string id)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT commission.fio ,commission.dolzhnost  FROM students ,commission WHERE (students.id_com1 = commission.id or students.id_com2 = commission.id or students.id_com3 = commission.id or students.id_com4 = commission.id )and students.id = {0}", Convert.ToInt32(id));


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }

        //



        //добавление вопросов гос
        internal bool SaveGosQuestion(string v1, string v2, string v3, string v4)
        {
            bool flagresult = false;
            string query = String.Format("INSERT INTO vopros_gos " + "(id ,voprosG) " + "VALUES ('{0}' ,'{1}')", v4, v1);
            string query1 = String.Format("INSERT INTO vopros_gos " + "(id ,voprosG) " + "VALUES ('{0}' ,'{1}')", v4, v2);
            string query2 = String.Format("INSERT INTO vopros_gos " + "(id ,voprosG) " + "VALUES ('{0}' ,'{1}')", v4, v3);
 
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                MySqlCommand myCommand1 = new MySqlCommand(query1, con);
                MySqlCommand myCommand2 = new MySqlCommand(query2, con);
              
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                    if (myCommand1.ExecuteNonQuery() == 1) flagresult = true;
                    if (myCommand2.ExecuteNonQuery() == 1) flagresult = true;
                   

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }
        //добавление идентификаторов вопроса
        internal bool AddStudentsQuestionGos(string v1, string id)
        {
            bool flagresult = false;
            string query = String.Format("UPDATE students " + "SET  id_voprosGos = '{0}' where id = '{1}'", v1 , id);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try

                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }
        internal bool AddStudentsQuestionDip(string v1, string id)
        {
            bool flagresult = false;
            string query = String.Format("UPDATE students " + "SET id_voprosDiplom = '{0}'  where id = '{1}'", v1,  id);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try

                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }

        //добавление вопросов диплом
        internal bool SaveDiplomQuestion(string v1, string v2, string v3, string v4, string v5 , string v6)
        {
            bool flagresult = false;
            string query = String.Format("INSERT INTO vopros_diplom " + "(id ,voprosD) " + "VALUES ('{0}' ,'{1}')" ,v6 ,v1);
            string query1 = String.Format("INSERT INTO vopros_diplom " + "(id ,voprosD) " + "VALUES ('{0}' ,'{1}')", v6, v2);
            string query2 = String.Format("INSERT INTO vopros_diplom " + "(id ,voprosD) " + "VALUES ('{0}' ,'{1}')", v6, v3);
            string query3 = String.Format("INSERT INTO vopros_diplom " + "(id ,voprosD) " + "VALUES ('{0}' ,'{1}')", v6, v4);
            string query4 = String.Format("INSERT INTO vopros_diplom " + "(id ,voprosD) " + "VALUES ('{0}' ,'{1}')", v6, v5);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                MySqlCommand myCommand1 = new MySqlCommand(query1, con);
                MySqlCommand myCommand2 = new MySqlCommand(query2, con);
                MySqlCommand myCommand3= new MySqlCommand(query3, con);
                MySqlCommand myCommand4 = new MySqlCommand(query4, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                    if (myCommand1.ExecuteNonQuery() == 1) flagresult = true;
                    if (myCommand2.ExecuteNonQuery() == 1) flagresult = true;
                    if (myCommand3.ExecuteNonQuery() == 1) flagresult = true;
                    if (myCommand4.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }


        // проверка на создан ли первый протакол..

        public bool checkOnFilling(string id)
        {
            bool fl = false;
            ArrayList checkFiling = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText =String.Format("SELECT id_voprosGos FROM students where id = {0} ", Convert.ToInt32(id));
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            if(MyDataReader["id_voprosGos"] == System.DBNull.Value)
                            {
                                
                                fl = false;
                            }
                    else
                            {
                            checkFiling.Add(result);MyDataReader.Close();
                                fl = true;
                            }
                    MyDataReader.Close();
                    return fl;

                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return fl;
                }
                finally
                {
                    myConnection.Close();
                }
            }
        }


        //////////////////////////////////////////////
        public ArrayList GetAllSecretar()
        {
            ArrayList allStudent = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = ("SELECT * FROM secretar");
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allStudent.Add(result);
                    MyDataReader.Close();
                    return allStudent;
                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }
            }
        }

        public ArrayList GetStudendDiplom(string idStudent)
        {
            ArrayList diplom = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT distinct * FROM diplom where id  = '{0}'",idStudent);
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            diplom.Add(result);
                    MyDataReader.Close();
                    return diplom;
                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        public ArrayList GetLogicDiplomGroupStudents(string idGroup)
        {
            ArrayList logic = new ArrayList();

            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string query = String.Format("Select logic from students where students.idGroup = '{0}'" , idGroup);
                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            logic.Add(result);

                    MyDataReader.Close();
                    return logic;
                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }
            }

        }
        public ArrayList GetLogicDopuscGosGroupStudents(string idGroup)
        {
            ArrayList logic = new ArrayList();

            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string query = String.Format("Select students.doposcGos from students where students.idGroup = '{0}'", idGroup);
                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            logic.Add(result);

                    MyDataReader.Close();
                    return logic;
                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }
            }

        }
        public ArrayList GetLogicDopuscDiplomGroupStudents(string idGroup)
        {
            ArrayList logic = new ArrayList();

            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string query = String.Format("Select students.dopuscDiplom from students where students.idGroup = '{0}'", idGroup);
                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            logic.Add(result);

                    MyDataReader.Close();
                    return logic;
                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }
            }

        }
        public ArrayList GetLogicYavkaGosGroupStudents(string idGroup)
        {
            ArrayList logic = new ArrayList();

            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string query = String.Format("Select students.yavkaGos from students where students.idGroup = '{0}'", idGroup);
                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            logic.Add(result);

                    MyDataReader.Close();
                    return logic;
                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }
            }

        }
        public ArrayList GetLogicYavkaDiplomGroupStudents(string idGroup)
        {
            ArrayList logic = new ArrayList();

            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string query = String.Format("Select students.yavkaDiplom from students where students.idGroup = '{0}'", idGroup);
                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            logic.Add(result);

                    MyDataReader.Close();
                    return logic;
                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }
            }

        }
        public ArrayList GetLogicDiplom()
        {
            ArrayList logic = new ArrayList();
           
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                     string query = String.Format("Select logic from students ");
                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            logic.Add(result);
                           
                    MyDataReader.Close();
                    return logic;
                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }
            }

        }



        public string GetLogicDiplom(string id)
        {
            string logic = "";

            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string query = String.Format("Select logic from students where id = {0}" , id);
                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            logic = (result as DbDataRecord)["logic"].ToString(); 

                    MyDataReader.Close();
                    return logic;
                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }
            }

        }

        internal bool SetLogicDiplom(string logicSet, string id)
        {
            bool flagresult = false;
            string query = String.Format("UPDATE students " + "SET logic = {0} where id = {1}",Convert.ToInt32( logicSet),Convert.ToInt32( id));
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try

                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }

        internal bool SetLogicYavkaDiplom(string logicSet, string id)
        {
            bool flagresult = false;
            string query = String.Format("UPDATE students " + "SET yavkaDiplom = {0} where id = {1}", Convert.ToInt32(logicSet), Convert.ToInt32(id));
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try

                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }

        internal bool SetLogicYavkaGos(string logicSet, string id)
        {
            bool flagresult = false;
            string query = String.Format("UPDATE students " + "SET yavkaGos = {0} where id = {1}", Convert.ToInt32(logicSet), Convert.ToInt32(id));
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try

                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }
        internal bool SetLogicDopuscGos(string logicSet, string id)
        {
            bool flagresult = false;
            string query = String.Format("UPDATE students " + "SET students.doposcGos = {0} where id = {1}", Convert.ToInt32(logicSet), Convert.ToInt32(id));
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try

                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }
        internal bool SetLogicDopuscDiplom(string logicSet, string id)
        {
            bool flagresult = false;
            string query = String.Format("UPDATE students " + "SET dopuscDiplom = {0} where id = {1}", Convert.ToInt32(logicSet), Convert.ToInt32(id));
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try

                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }
        public DataTable GetAllStudentsTest()
        {
            DataTable datatable = new DataTable();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {

                myConnection.Open();
                string CommandText = ("SELECT distinct *  FROM students ");
                MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
               
               

                Program.dataadapter = new MySqlDataAdapter(myCommand);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(Program.dataadapter);

                Program.dataadapter.Fill(datatable);
                myConnection.Close();
               

                datatable.Columns.Add("Сдавал диплом/не сдавал", typeof(Boolean));

                return datatable;
            }
            
            }


        public ArrayList GetAllStudents()
        {
            ArrayList allStudent = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = ("SELECT * FROM students");
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allStudent.Add(result);
                    MyDataReader.Close();
                    return allStudent;
                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        //добавление идентификаторов членов комиссии

        //добавление идентификаторов членов комиссии
        internal bool addCommissionDip(string com1, string com2, string com3,string com4 , string id, int predsedatel, string secretar)
        {
            bool flagresult = false;
            string query = String.Format("UPDATE students " + "SET id_chairmanD = {0} , id_comD1 = '{1}',id_comD2 = '{2}',id_comD3 = '{3}' , id_comD4 = '{4}' ,id_secretarD = '{5}' where id = '{6}'", predsedatel, com1, com2, com3,com4, secretar, id);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }

        internal bool addCommissionGos(string com1 , string com2 , string com3 , string com4, string id ,int predsedatel ,string secretar)
        {
            bool flagresult = false;
            string query = String.Format("UPDATE students " + "SET id_chairman = {0} , id_com1 = '{1}',id_com2 = '{2}',id_com3 = '{3}' ,id_com4 = '{4}', id_secretar = '{5}' where id = '{6}'", predsedatel,com1 ,com2 , com3, com4, secretar, id);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }

        internal bool SaveNewStudent(string fio, string idgroup, int gos_ocenka, int id_diplom, int id_commision,int logic , int otdelenie , int god_vipuska)
        {
            bool flagresult = false;
            string query = String.Format("INSERT INTO students " + "(Sfio ,idGroup, logic , logicotdelenie , god_vipuska) " + "VALUES ('{0}','{1}' , {2} ,{3} , {4})",fio,  idgroup, logic , otdelenie, god_vipuska);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }

        internal bool CreateGroup(string name, string newname )
        {
            bool flagresult = false;
            string query = String.Format("UPDATE group1 " + "SET Gname = '{0}' where Gname = '{1}'", newname , name);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
           
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }

        internal bool CreateGosExamen( int id_studenta,int ocenka   )
        {
            bool flagresult = false;
           
            string query1 = String.Format("UPDATE students " + "SET gos_ocenka = {0} where id = {1} " , ocenka , id_studenta);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
              
                MySqlCommand myCommand1 = new MySqlCommand(query1, con);
                try

                {
                    con.Open();
                   
                    if (myCommand1.ExecuteNonQuery() == 1) flagresult = true;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }


        internal bool CreateDiplomForStudent(string name , int ocenka , string nauch_rucov , string recenzent , int student_id ,string dolzhnostrecenzent , string id_diplom ,int ocenkaRecenzent , int kolstr , int kolstrtab)
        {
            bool flagresult = false; 
            string query = String.Format("INSERT INTO diplom " + "(id , ocenka , name , nauch_rucov , recenzent , recenzent_dolzhnost  , kolstr , kolstrtab , ocenkaRecenzent) VALUES ('{0}',{1},'{2}','{3}','{4}','{5}',{6},{7},{8})", id_diplom, ocenka, name, nauch_rucov, recenzent ,dolzhnostrecenzent , kolstr , kolstrtab , ocenkaRecenzent);
            string query1 = String.Format("UPDATE students " + "SET id_diplom ='{0}' where id = {1} ",id_diplom , student_id);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                 MySqlCommand myCommand = new MySqlCommand(query, con);
                 MySqlCommand myCommand1 = new MySqlCommand(query1, con);
                try

                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                    if (myCommand1.ExecuteNonQuery() == 1) flagresult = true;
                }
                catch (System.Exception ex)
                {
                  //  MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }

        }


        internal bool DeleteGroup(string name)
        {
            bool flagresult = false;
            string query = String.Format("DELETE FROM group1 " + "WHERE Gname='{0}'" ,name);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return flagresult;
                }

        }

        internal object GetAllStudentsForGroup(string groupId)
        {
            ArrayList allStudents = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT * FROM students Where idGroup='{0}'" , groupId);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);


                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allStudents.Add(result);
                    MyDataReader.Close();
                    return allStudents;
                }
                catch (System.Exception ex)
                {
                  //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }



        




        internal object GetAllDiplom(string id)
        {
            ArrayList allDiplom = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT * FROM diplom ,students  where (students.id_diplom = diplom.id) and (students.id = {0}) ",Convert.ToInt32(id));
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allDiplom.Add(result);
                    MyDataReader.Close();
                    return allDiplom;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }

        //выбор всех председателей
        internal object GetAllChairman()
        {
            ArrayList allChairman = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT * FROM chairman");
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allChairman.Add(result);
                    MyDataReader.Close();
                    return allChairman;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }

        internal object GetAllStudentsInform()
        {
            ArrayList allChairman = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT students.Sname , students.Sfirstname, students.Ssecondname,students.gos_ocenka ,diplom.ocenka , secretar.name , secretar.dolzhnost   FROM students , diplom, secretar where (students.id_diplom = diplom.id) and (secretar.id = students.id_secretar )");
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allChairman.Add(result);
                    MyDataReader.Close();
                    return allChairman;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }

        internal object GetNauchRucov()
        {
            ArrayList allChairman = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT * FROM nauch_rucovoditeli");
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allChairman.Add(result);
                    MyDataReader.Close();
                    return allChairman;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }
        internal object GetRecenzenti()
        {
            ArrayList allChairman = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT * FROM recenzenti");
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allChairman.Add(result);
                    MyDataReader.Close();
                    return allChairman;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }

        //добавление председателя
        public bool SaveNewChairman(string fio, string dolzhnost)
        {
            bool flagresult = false;
            string query = String.Format("INSERT INTO chairman" + "(name ,post)" + "VALUES ('{0}' ,'{1}')", fio, dolzhnost);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }



        }


        public bool SaveNewSecretar(string fio, string dolzhnost)
        {
            bool flagresult = false;
            string query = String.Format("INSERT INTO secretar" + "(name ,dolzhnost)" + "VALUES ('{0}' ,'{1}')", fio, dolzhnost);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }



        }


        // добавление члена комиссии
        public bool SaveNewCommision(string fio , string dolzhnost)
        {
            bool flagresult = false;
            string query = String.Format("INSERT INTO commission" + "(fio ,dolzhnost)" + "VALUES ('{0}' ,'{1}')", fio ,dolzhnost);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }



        }

        public bool SaveNewGroup(string name , string id) {
            bool flagresult = false;
            string query = String.Format("INSERT INTO group1" + "( Gname , Gspecialnost)" + "VALUES ('{0}','{1}')", name,id);
            using (MySqlConnection con = new MySqlConnection(myConnectionString)) {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                   if( myCommand.ExecuteNonQuery()==1) flagresult = true  ;
                   
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }



        }


        public bool SaveNewRecenzent(string fio, string dolzhnost)
        {
            bool flagresult = false;
            string query = String.Format("INSERT INTO recenzenti " + "( fio , dolzhnost)" + "VALUES ('{0}','{1}')", fio, dolzhnost);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }



        }
        public bool SaveNewNauchRucov(string fio, string dolzhnost)
        {
            bool flagresult = false;
            string query = String.Format("INSERT INTO nauch_rucovoditeli " + "( fio , dolzhnost)" + "VALUES ('{0}','{1}')", fio, dolzhnost);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }



        }
        public bool SaveNewSpecialnost(string id , string spec)
        {
            bool flagresult = false;
            string query = String.Format("INSERT INTO specialnost" + "(id ,specialnost)" + "VALUES ('{0}','{1}')", id, spec);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }



        }

        
            internal object GetAllGroupsForSpecialnost(string spec)
        {
            ArrayList allChairman = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT distinct * FROM group1 where group1.Gspecialnost = '{0}'" , spec);
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allChairman.Add(result);
                    MyDataReader.Close();
                    return allChairman;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }




        internal object GetAllSpecialnost()
        {
            ArrayList allChairman = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT distinct * FROM specialnost");
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allChairman.Add(result);
                    MyDataReader.Close();
                    return allChairman;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }
        internal ArrayList GetDateGos(string id)
        {
            ArrayList allChairman = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT distinct dateGos FROM students where id = '{0}'", id);
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allChairman.Add(result);
                    MyDataReader.Close();
                    return allChairman;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }

        public bool SaveNewCommissionGroup(List <string> commission, string group, string date , string idChairman , string idSecretar)
        {
            bool flagresult = false;
            string query = String.Format("INSERT INTO commissiongroup ( commission1 ,commission2,commission3,commission4,commissiongroup.group,year , predsedatelID ,secretarID ) VALUES ('{0}','{1}','{2}','{3}','{4}',{5}, '{6}' ,'{7}')", commission[0].ToString(), commission[1].ToString(), commission[2].ToString(), commission[3].ToString(), group,Convert.ToInt32(date) ,idChairman , idSecretar);
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                  // MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }
            }




        public bool UpdateCommissionGroup(List<string> commission, string group, string date, string idChairman, string idSecretar)
        {
            string CommandText = String.Format("update commissiongroup set  commission1 = '{0}' ,commission2= '{1}',commission3= '{2}',commission4= '{3}', predsedatelID= '{4}' ,secretarID= '{5}'  where commissiongroup.group = '{6}' and commissiongroup.year = {7}", commission[0].ToString(), commission[1].ToString(), commission[2].ToString(), commission[3].ToString(), idChairman, idSecretar , group, Convert.ToInt32(date));
            bool flagresult = false;
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(CommandText, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    // MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }
        }



        public bool UpdateDiplomStudent(string id, int ocenka, string name, string nauch_rucov , string recenzent , string recenzent_dolzhnost , string kolstr , string kolstrtab , string ocenkaRecenzent)
        {
            string CommandText = String.Format("update diplom set  ocenka = {0} ,name= '{1}',nauch_rucov= '{2}',recenzent= '{3}', recenzent_dolzhnost= '{4}' , kolstr= '{5}'  , kolstrtab= '{6}' , ocenkaRecenzent= '{7}' where diplom.id = '{8}'",ocenka , name , nauch_rucov ,recenzent ,     recenzent_dolzhnost , kolstr , kolstrtab , ocenkaRecenzent , id);
            bool flagresult = false;
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(CommandText, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    // MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }
        }
        public bool UpdateGosDate(string date , string id)
        {
            string CommandText = String.Format("update students set  dateGos = '{0}' where students.id = '{1}'", date, id);
            bool flagresult = false;
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(CommandText, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    // MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }
        }

        public bool UpdateDiplomDate(string date, string id)
        {
            string CommandText = String.Format("update students set  dateDiplom = '{0}' where students.id = '{1}'", date, id);
            bool flagresult = false;
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(CommandText, con);
                try
                {
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1) flagresult = true;

                }
                catch (System.Exception ex)
                {
                    // MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                return flagresult;
            }
        }
        public ArrayList GetCommissionGroup(int year , string group)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT *  FROM commissiongroup WHERE (year = {0} and commissiongroup.group = '{1}')", year , group);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }

        public ArrayList GetCommissionId(ArrayList ar)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT *  FROM commission WHERE ((id = {0}) or (id = {1}) or (id ={2}) or (id ={3}))", Convert.ToInt32(ar[0]), Convert.ToInt32(ar[1]), Convert.ToInt32(ar[2]), Convert.ToInt32(ar[3]));


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        public ArrayList GetChairmanId(ArrayList ar)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT *  FROM chairman WHERE ((id = {0}))", Convert.ToInt32(ar[0]));


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }

        public ArrayList GetSecretarId(ArrayList ar)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT *  FROM secretar WHERE ((id = {0}))", Convert.ToInt32(ar[0]));


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        //выбор всех членов комиссии
        internal object GetAllCommission()
        {
            ArrayList Commission = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT * FROM commission");
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            Commission.Add(result);
                    MyDataReader.Close();
                    return Commission;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }




      // public void addDateTimeProtocol(DateTime date , string nachalo , string conec)
      // {
      //     
      // }
      //
        internal object GetCommission(ArrayList ar)
        {
            ArrayList Commission = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT * FROM commission where (id = {0}) or (id = {1}) or (id = {2} or (id = {3})", ar[0],ar[1],ar[2],ar[3]);
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            Commission.Add(result);
                    MyDataReader.Close();
                    return Commission;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }

        internal string GetGroupStudent(string id)
        {
            string group = "" ;
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT distinct * FROM group1 where (id = '{0}')", id);
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            group = ( result as DbDataRecord)["id"].ToString() + " -  " + (result as DbDataRecord)["Gname"].ToString();
                    
            
                    MyDataReader.Close();
                    return group;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }

        public ArrayList GetAllStudentsTestForGroup(string groupid)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT distinct specialnost.id , specialnost.specialnost  FROM specialnost , group1 where group1.Gspecialnost = specialnost.id and group1.id = {0}", groupid);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        public ArrayList GetAllStudentsTestForGroup1(string groupid)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("SELECT distinct *  FROM group1 where group1.id = {0}", groupid);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        public DataTable GetAllStudentsTestForGroupTest(string groupid)
        {
            DataTable datatable = new DataTable();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {

                myConnection.Open();
                string CommandText = String.Format("SELECT distinct *  FROM students where students.idGroup = '{0}' ", groupid);
                MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);



                Program.dataadapter = new MySqlDataAdapter(myCommand);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(Program.dataadapter);

                Program.dataadapter.Fill(datatable);
                myConnection.Close();


                datatable.Columns.Add("Сдавал диплом/не сдавал", typeof(Boolean));
                datatable.Columns.Add("Допущен к Гос / не допущен", typeof(Boolean));
                datatable.Columns.Add("Допущен к диплому / не допущен", typeof(Boolean));
                datatable.Columns.Add("Явка ГОС / не явка", typeof(Boolean));
                datatable.Columns.Add("Явка Диплом / не явка", typeof(Boolean));
                return datatable;
            }

        }

        public void openDirectory(string name) {

            Process.Start("explorer", Application.StartupPath + "\\" + Program.group + "\\" + Program.groupNameGroup + "\\"+name);
        }
        // добавление папки

        public void createFolserStudent(string name )
        {
            string pathFile = String.Format(Application.StartupPath + "\\Shablon");
            string path = String.Format(Application.StartupPath + "\\" +Program.group + "\\" + Program.groupNameGroup +  "\\"+ name);
            string pathGroup  = String.Format(Application.StartupPath + "\\" + Program.group);

            DirectoryInfo dirInfo = new System.IO.DirectoryInfo(path);
            
            if (!dirInfo.Exists )
            {
                      
                        dirInfo.Create();
                try
                {
                   // DirectoryInfo dirInfo1 = new DirectoryInfo(pathFile);
                   // foreach (FileInfo file in dirInfo1.GetFiles("*.*"))
                   // {
                   //     File.Copy(file.FullName, path + "\\" + file.Name, true);
                   // }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

    public string BukChisl(string ocenka)
        {   string bukchis = "";
            int ocen = Convert.ToInt32(ocenka);
            if(ocen >= 95) { bukchis = "A  4,0"; }
            else if(ocen >=90 && ocen <= 94) { bukchis =   "A-  3,67"; }
            else if(ocen >= 85 && ocen <= 89) { bukchis =  "B+  3,33"; }
            else if (ocen >= 80 && ocen <= 84) { bukchis = "B   3,0"; }
            else if (ocen >= 75 && ocen <= 79) { bukchis = "B-  2,67"; }
            else if (ocen >= 70 && ocen <= 74) { bukchis = "C+  2,33"; }
            else if (ocen >= 65 && ocen <= 69) { bukchis = "C   2,0"; }
            else if (ocen >= 60 && ocen <= 64) { bukchis = "C-  1,67"; }
            else if (ocen >= 55 && ocen <= 59) { bukchis = "D+  1,33"; }
            else if (ocen >= 50 && ocen <= 54) { bukchis = "D   1,0"; }
            else if (ocen >= 0 && ocen <= 49) { bukchis =  "F   0"; }
            return bukchis; 
        }
        internal List<string> GetGroupIDSpecialnost(string id)
        {
            List<string> ar = new List<string>();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("select distinct group1.id from group1 where ((group1.Gspecialnost = '{0}')) ",id);
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            ar.Add(("'" +( result as DbDataRecord)["id"].ToString())+ "'");
                    MyDataReader.Close();
                    return ar;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }


        //метод для извличения идентификационных номеров дипломов студентов 
        internal List<string> GetDiplomIDSpecialnost( string group ,int logicOtdelenie , int dopusk , int year )
        {
            List<string> ar = new List<string>();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("Select distinct students.id_diplom from students  , diplom where (students.idGroup = {0}) and  (students.logicotdelenie = {1}) and (students.dopuscDiplom = {2}) and (god_vipuska = {3})  ", group , logicOtdelenie , dopusk ,year );
                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection); MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            ar.Add("'"+ (result as DbDataRecord)["id_diplom"].ToString() + "'");
                    MyDataReader.Close();
                    return ar;
                }
                catch (System.Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }


        // методы для формирования годового отчета
        public ArrayList KolDopGosZaoch(string group , int year)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("Select students.gos_ocenka from students where  students.logicotdelenie = 0 and students.doposcGos = 1 and god_vipuska = {0} and (students.idGroup = {1}) ;",  year,group  );


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        public ArrayList DopGosZaochOcenkiGos(string group, int year)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("Select students.gos_ocenka from students where  students.logicotdelenie = 0 and students.doposcGos = 1 and god_vipuska = {0} and (students.idGroup = {1}) ;", year, group);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add((result as DbDataRecord)["gos_ocenka"]);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        public ArrayList KolNeyavkiZaoch(string group, int year)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("Select students.gos_ocenka from students where  students.logicotdelenie = 0 and students.doposcGos = 1 and god_vipuska = {0} and yavkaGos = 0 and (students.idGroup = {1}) ;", year, group);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }


        public ArrayList KolDopDiplomZaoch(string idDiplom)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("Select  diplom.ocenka from  diplom where  (diplom.id = {0})",idDiplom);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add((result as DbDataRecord)["ocenka"]);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        public ArrayList KolNeyavkiZaochDiplom(string id)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("Select  students.Sfio from students  where  (students.idGroup = {0}) and students.yavkaDiplom = 0;", id);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }

        public ArrayList ColOcenokD(ArrayList ar)
        {
            int ocen = 0;
            int otl = 0;
            int hor = 0;
            int udovlet = 0;
            int neud = 0;

            for (int i = 0; i < ar.Count; i++)
            {

                ocen = Convert.ToInt32(ar[i]);

                if (ocen >= 90) { otl++; }

                else if (ocen >= 75 && ocen <= 89) { hor++; }

                else if (ocen >= 60 && ocen <= 74) { udovlet++; }

                else if (ocen >= 0 && ocen <= 59) { neud++; }



            }
            ArrayList ar1 = new ArrayList();
            ar1.Add(otl.ToString());
            ar1.Add(hor.ToString());
            ar1.Add(udovlet.ToString());
            ar1.Add(neud.ToString());
            return ar1;


        }
        public ArrayList ColOcenok(ArrayList ar)
        {
            int ocen = 0;
            int otl = 0;
            int hor = 0;
            int udovlet = 0;
            int neud = 0;

            for (int i = 0; i<ar.Count; i++) {

               ocen =  Convert.ToInt32((ar[i] as DbDataRecord)["gos_ocenka"]);

                if (ocen >= 90) { otl++; }

                else if (ocen >= 75 && ocen <= 89) { hor++; }

                else if (ocen >= 60 && ocen <= 74) { udovlet++; }

                else if (ocen >= 0 && ocen <= 59) { neud++; }

               

            }
            ArrayList ar1 = new ArrayList();
            ar1.Add(otl.ToString());
            ar1.Add(hor.ToString());
            ar1.Add(udovlet.ToString());
            ar1.Add(neud.ToString());
            return ar1;
           
           
        }

        // очное отделение

        public ArrayList KolDopGosOch(string group, int year)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("Select students.gos_ocenka from students where   students.logicotdelenie = 1 and students.doposcGos = 1 and god_vipuska = {0} and (students.idGroup = {1});", year,group );


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        public ArrayList DopGosOchOcenkiGos(string group, int year)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("Select students.gos_ocenka from students where  students.logicotdelenie = 1 and students.doposcGos = 1 and god_vipuska = {0} and  (students.idGroup = {1});", year, group);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add((result as DbDataRecord)["gos_ocenka"]);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        public ArrayList KolNeyavkiOch(string group, int year)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("Select students.gos_ocenka from students where   students.logicotdelenie = 1 and students.doposcGos = 1 and god_vipuska = {0} and yavkaGos = 0 and (students.idGroup = {1});", year ,group);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }


        public ArrayList KolDopDiplomOch(string idDiplom)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("Select  diplom.ocenka from  diplom where  (diplom.id = {0})", idDiplom);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add((result as DbDataRecord)["ocenka"]);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
        public ArrayList KolNeyavkiOchDiplom(string id)
        {
            ArrayList allData = new ArrayList();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                try
                {
                    myConnection.Open();
                    string CommandText = String.Format("Select  students.Sfio from students  where  (students.idGroup = {0}) and students.yavkaDiplom = 0;", id);


                    MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                    MySqlDataReader MyDataReader;
                    MyDataReader = myCommand.ExecuteReader();

                    if (MyDataReader.HasRows)
                        foreach (DbDataRecord result in MyDataReader)
                            allData.Add(result);
                    MyDataReader.Close();
                    return allData;
                }
                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    myConnection.Close();
                }
            }
        }


    }



}
