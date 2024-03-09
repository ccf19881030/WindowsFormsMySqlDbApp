using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMySqlDbApp
{
    public partial class DashBoardForm : Form
    {
        List<Person> people = new List<Person>();   // 查询结果列表
        public DashBoardForm()
        {
            InitializeComponent();

            // 更新绑定内容
            UpdateBinding();
        }
        /// <summary>
        /// 刷新ListBox中的数据，将peopleFoundListBox和peopl列表数据进行绑定，并显示FullInfo字段内容
        /// </summary>

        public void UpdateBinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }
        /// <summary>
        /// search按钮单击响应处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void searchButton_Click(object sender, EventArgs e)
        {
            // 创建MySQLDataAccess类对象
            MySQLDataAccess dataAccess = new MySQLDataAccess();
            // 根据UI窗体用户输入的LastName字段，调用dataAccess对象的GetPersonList接口从people表查询数据
            people = dataAccess.GetPersonList(lastNameTextBox.Text);

            // 更新绑定内容，将people查询结果展示在peopleFoundListBox中
            UpdateBinding();
        }

        /// <summary>
        /// insert按钮响应处理函数
        /// 功能：接收用户输入，往people数据表中插入记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertDataButton_Click(object sender, EventArgs e)
        {
            MySQLDataAccess dataAccess = new MySQLDataAccess();
            // 插入一条数据记录到people表中
            dataAccess.InsertPerson(firstNameInsTextBox.Text, lastNameInsTextBox.Text, emailAddressInsTextBox.Text);

            // 插入数据之后将界面中的记录数据清空
            firstNameInsTextBox.Text = "";
            lastNameInsTextBox.Text = "";
            emailAddressInsTextBox.Text = "";
        }
    }
}
