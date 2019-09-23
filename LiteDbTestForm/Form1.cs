using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using LiteDbTestForm.DataType;

namespace LiteDbTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonInitDataBase_Click(object sender, EventArgs e)
        {
            textBoxLog.Text += $"[InitDataBase] Use Path : {textBoxDataBasePath.Text}\r\n";

            database = new LiteDatabase(textBoxDataBasePath.Text); // 지정된 경로로 초기화
            userCollection = database.GetCollection<User>("users");
        }

        private void ButtonSelectData_Click(object sender, EventArgs e)
        {
            listBoxSelectData.Items.Clear();
            textBoxLog.Text += $"[SelectData] Select All Data\r\n";

            var userList = userCollection.FindAll().ToList();

            foreach (var user in userList)
            {
                listBoxSelectData.Items.Add($"{user.Id}, {user.Password}, {user.Name}");

                textBoxLog.Text += $"[SelectData] Select Data : {user.Id}, {user.Password}, {user.Name}\r\n";
            }
        }

        private void ButtonInsertData_Click(object sender, EventArgs e)
        {
            var tmpData = textBoxQueryData.Text.Split(','); // 데이터는 , 으로 구분한다.

            if (tmpData.Length == 3) // 데이터가 3개 인지 확인한다.
            {
                textBoxLog.Text += $"[InsertData] Select Data : {tmpData[0]}, {tmpData[1]}, {tmpData[2]}\r\n";
                userCollection.Insert(new User()
                {
                    Id = tmpData[0],
                    Password = tmpData[1],
                    Name = tmpData[2]
                }); // 데이터를 넣어준다.
            }
            else
            {
                textBoxLog.Text += "[InsertData] Data Parser Error Use : {data1},{data2},{data3}";
                MessageBox.Show("잘못된 데이터 입니다."); // 3개가 아니면 잘못된 입력이다.
            }
        }

        private void ButtonFindData_Click(object sender, EventArgs e)
        {
            listBoxSelectData.Items.Clear();
            textBoxLog.Text += $"[FindData] Find All Data\r\n";

            var userList = userCollection.Find(ParserQuery(textBoxQueryData.Text)).ToList();

            foreach (var user in userList)
            {
                listBoxSelectData.Items.Add($"{user.Id}, {user.Password}, {user.Name}");

                textBoxLog.Text += $"[SelectData] Find Data : {user.Id}, {user.Password}, {user.Name}\r\n";
            }
        }

        private void ButtonUpdateData_Click(object sender, EventArgs e)
        {
            var tmpData = textBoxQueryData.Text.Split(','); // 데이터는 , 으로 구분한다.

            if (tmpData.Length == 3) // 데이터가 3개 인지 확인한다.
            {
                userCollection.Update(new User()
                {
                    Id = tmpData[0],
                    Password = tmpData[1],
                    Name = tmpData[2]
                }); // 데이터를 넣어준다.
            }
            else
            {
                MessageBox.Show("잘못된 데이터 입니다."); // 3개가 아니면 잘못된 입력이다.
            }
        }

        private void ButtonSelectDataBasePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog(); // DB파일 경로를 가져옴

            if (fd.FileName.Length > 0)
            {
                textBoxDataBasePath.Text = fd.FileName;
            }
        }

        private Query ParserQuery(string data)
        {
            Query tmpQuery = default;
            var tmpData = data.Split(' ');
            switch (tmpData[0].ToUpper())
            {
                case "EQ":
                    tmpQuery = Query.EQ(tmpData[1], tmpData[2]);
                    break;
                case "GTE":
                    tmpQuery = Query.GTE(tmpData[1], tmpData[2]);
                    break;
                case "GT":
                    tmpQuery = Query.GT(tmpData[1], tmpData[2]);
                    break;
                case "LT":
                    tmpQuery = Query.LT(tmpData[1], tmpData[2]);
                    break;
                case "LTE":
                    tmpQuery = Query.LTE(tmpData[1], tmpData[2]);
                    break;
                case "BETWEEN":
                    tmpQuery = Query.Between(tmpData[1], tmpData[2], tmpData[3]);
                    break;
                case "IN":
                    tmpQuery = Query.In(tmpData[1], tmpData[2]);
                    break;
                case "NOT":
                    tmpQuery = Query.Not(tmpData[1], tmpData[2]);
                    break;
                case "STARTWITH":
                    tmpQuery = Query.StartsWith(tmpData[1], tmpData[2]);
                    break;
                case "CONTAINS":
                    tmpQuery = Query.Contains(tmpData[1], tmpData[2]);
                    break;
                case "ALL":
                    tmpQuery = Query.All(tmpData[1]);
                    break;
            }

            return tmpQuery;
        }

        // DB 선언
        private static LiteDatabase database;
        private static LiteCollection<User> userCollection;
    }
}
