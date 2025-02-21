using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT3A1_WinForm
{
    internal class Student
    {
        public int ID { get; set; }
        public string SID { get; set; }
        public string Name { get; set; }
        public Sex Gender { get; set; }
        public Shift StudyShift { get; set; }
        public Address PoB { get; set; }
        public string Info
        {
            get
            {
                return "ID: " + SID + ", Name: " + Name;
            }
        }
        public bool AddStudent()
        {
            try
            {
                //Open connectoin
                MyConfig.AccCon.Open();
                //Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "INSERT INTO tblStudent([SID], [Sname], " +
                    "[Gender], [StudyShift], [PoB]) VALUES(@sid, " +
                    "@sname, @gender, @studyShift, @pob)";
                cmd.Parameters.AddWithValue("sid", SID);
                cmd.Parameters.AddWithValue("sname", Name);
                cmd.Parameters.AddWithValue("gender", Gender);               
                cmd.Parameters.AddWithValue("studyShift", StudyShift);
                cmd.Parameters.AddWithValue("pob", PoB);

                //Execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
        public bool DeleteStudent()
        {
            try
            {
                //Open connectoin
                MyConfig.AccCon.Open();
                //Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "DELETE FROM tblStudent WHERE [ID]=@id";
                cmd.Parameters.AddWithValue("id", ID);

                //Execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
        public bool UpdateStudent()
        {
            try
            {
                //Open connectoin
                MyConfig.AccCon.Open();
                //Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "UPDATE tblStudent SET [SID]=@sid, " +
                    "[SName]=@name, [Gender]=@gender, [StudyShift]=@shift, " +
                    "[PoB]=@pob WHERE [ID]=@id";
                cmd.Parameters.AddWithValue("sid", SID);
                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("gender", Gender);
                cmd.Parameters.AddWithValue("shift", StudyShift);
                cmd.Parameters.AddWithValue("pob", PoB);
                cmd.Parameters.AddWithValue("id", ID);

                //Execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
        public static void FetchDataToListView(ListView lv)
        {
            try
            {
                //Open connectoin
                MyConfig.AccCon.Open();
                //Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "SELECT * FROM [tblStudent] ORDER BY SID";

                //Create DataReader and execute command
                OleDbDataReader reader = cmd.ExecuteReader();
                lv.Items.Clear();
                while (reader.Read())
                {
                    //Creating object to store student info
                    Student objStu = new Student();
                    objStu.ID = (int)reader[0];
                    objStu.SID = reader[1].ToString();
                    objStu.Name = reader[2].ToString();
                    objStu.Gender = (Sex)reader[3];
                    objStu.StudyShift = (Shift)reader[4];
                    objStu.PoB = (Address)reader[5];

                    //Creating array to store student's info
                    string[] stuInfo = new string[5];
                    stuInfo[0] = objStu.SID;
                    stuInfo[1] = objStu.Name;
                    if (objStu.Gender == Sex.Male)
                        stuInfo[2] = "ប្រុស";
                    else
                        stuInfo[2] = "ស្រី";

                    if (objStu.StudyShift == Shift.Morning)
                        stuInfo[3] = "ព្រឹក";
                    else if (objStu.StudyShift == Shift.Afternoon)
                        stuInfo[3] = "ថ្ងៃ";
                    else
                        stuInfo[3] = "យប់";

                    if (objStu.PoB == Address.Phnom_Penh)
                        stuInfo[4] = "ភ្នំពេញ";
                    else
                        stuInfo[4] = "ខេត្ត";

                    //Creating ListViewItem from array
                    ListViewItem stu = new ListViewItem(stuInfo);
                    stu.Tag = objStu;
                    lv.Items.Add(stu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
        public static bool ClearData()
        {
            try
            {
                //Open connectoin
                MyConfig.AccCon.Open();
                //Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "DELETE FROM tblStudent";

                //Execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
    }
}
