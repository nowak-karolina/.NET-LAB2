using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Json;

namespace App {
    public partial class Form1 : Form {
        private HttpClient client;
        private ToDoDataBase tododoDB;
        ToDo json;
        string call = "http://www.boredapi.com/api/activity/";


        public Form1() {
            InitializeComponent();
            client = new HttpClient();
            tododoDB = new ToDoDataBase();
            LoadData();
            dataGridView1.AutoResizeColumns();
            type_input.SelectedIndex = 0;
            typeFilter_comboBox.SelectedIndex = 0;
            sorting_comboBox.SelectedIndex = 0;
            data_textBox.Text = "";
        }

        private void getCall() {
            call = "http://www.boredapi.com/api/activity?";
            if (accessibility_input.Enabled) {
                decimal param = accessibility_input.Value;
                call += "accessibility=" + (param).ToString().Replace(",", ".") + "&";
            }
            if (type_input.Enabled) {
                call += "type=" + type_input.Text + "&";
            }
            if (parti_input.Enabled) {
                decimal param = parti_input.Value;
                call += "participants=" + (param).ToString().Replace(",", ".") + "&";
            }
            if (price_input.Enabled) {
                decimal param = price_input.Value;
                call += "price=" + (param).ToString().Replace(",", ".") + "&";
            }
            if (!accessibility_input.Enabled && !type_input.Enabled && !parti_input.Enabled && !price_input.Enabled) {
                call = "http://www.boredapi.com/api/activity/";
            }
        }

        private async void getData(object sender, EventArgs e) {
            getCall();
            textBox1.Text = call;
            string response = await client.GetStringAsync(call);
            data_textBox.Text = response;
            try {
                json = JsonSerializer.Deserialize<ToDo>(response);
                json_textBox.Text = json.ToString();
            }
            catch (Exception ex) {
                json_textBox.Text = "";
                MessageBox.Show("Error: No activity found with the specified parameters", "No activities", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void AddToDB_button_Click(object sender, EventArgs e) {
            var existingItem = tododoDB.todos.FirstOrDefault(item => item.key == json.key);

            if (existingItem == null) {
                tododoDB.todos.Add(new ToDo { activity = json.activity, accessibility = json.accessibility, type = json.type, participants = json.participants, price = json.price, link = json.link, key = json.key });
                tododoDB.SaveChanges();
                LoadData();
            } else {
                MessageBox.Show("Error: This item already exists in the database.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LoadData() {
            var todos = tododoDB.todos.ToList();

            dataGridView1.DataSource = todos;

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["activity"].HeaderText = "Activity";
            dataGridView1.Columns["accessibility"].HeaderText = "Accessibility";
            dataGridView1.Columns["type"].HeaderText = "Type";
            dataGridView1.Columns["participants"].HeaderText = "Participants";
            dataGridView1.Columns["price"].HeaderText = "Price";
            dataGridView1.Columns["link"].HeaderText = "Link";
            dataGridView1.Columns["key"].HeaderText = "Key";

            dataGridView1.AutoResizeColumns();
        }

        private void clear_button_Click(object sender, EventArgs e) {
            tododoDB.todos.RemoveRange(tododoDB.todos);
            tododoDB.SaveChanges();
            LoadData();

        }


        private void CheckBoxChecked(object sender, EventArgs e) {
            if (sender is CheckBox) {
                CheckBox checkBox = sender as CheckBox;

                switch (checkBox.Name) {
                    case "a_checbox":
                        if (checkBox.Checked) {
                            accessibility_input.Enabled = true;
                        } else {
                            accessibility_input.Enabled = false;
                        }
                        break;

                    case "t_checkbox":
                        if (checkBox.Checked) {
                            type_input.Enabled = true;
                        } else {
                            type_input.Enabled = false;
                        }
                        break;

                    case "parti_checkbox":
                        if (checkBox.Checked) {
                            parti_input.Enabled = true;
                        } else {
                            parti_input.Enabled = false;
                        }
                        break;

                    case "price_checkBox":
                        if (checkBox.Checked) {
                            price_input.Enabled = true;
                        } else {
                            price_input.Enabled = false;
                        }
                        break;
                }

            }

        }

        private void priceSort_button_Click(object sender, EventArgs e) {

            dataGridView1.DataSource = tododoDB.todos.OrderBy(s => s.price).Reverse().ToList();
        }

        private void sorting_comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            //
            typeFilter_comboBox.SelectedIndex = 0;

            if (sender is ComboBox) {
                ComboBox comboBox = sender as ComboBox;

                switch (comboBox.SelectedIndex) {
                    case 0:
                        LoadData();
                        break;

                    case 1:
                        dataGridView1.DataSource = tododoDB.todos.OrderBy(s => s.accessibility).Reverse().ToList();
                        break;

                    case 2:
                        dataGridView1.DataSource = tododoDB.todos.OrderBy(s => s.participants).Reverse().ToList();
                        break;

                    case 3:
                        dataGridView1.DataSource = tododoDB.todos.OrderBy(s => s.price).Reverse().ToList();
                        break;

                    case 4:
                        dataGridView1.DataSource = tododoDB.todos.OrderBy(s => s.key).Reverse().ToList();
                        break;
                }
            }
        }

        private void remove_button_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) {
                if (row.DataBoundItem is ToDo toDo) { //Pobiera obiekt powi¹zany z danymi, który wype³ni³ wiersz.
                    tododoDB.todos.Remove(toDo);
                }
            }

            tododoDB.SaveChanges();
            LoadData();

        }

        private void showAccessibilityInfo(object sender, EventArgs e) {
            toolTip1.Show("A factor describing how possible an event is to do with zero being the most accessible", info1);
        }

        private void info2_MouseHover(object sender, EventArgs e) {
            toolTip1.Show("Type of the activity", info2);
        }

        private void info3_MouseHover(object sender, EventArgs e) {
            toolTip1.Show("The number of people that this activity could involve", info3);
        }

        private void info4_MouseHover(object sender, EventArgs e) {
            toolTip1.Show("A factor describing the cost of the event with zero being free", info4);
        }

        private void typeFilter_comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            sorting_comboBox.SelectedIndex= 0;

            if (sender is ComboBox) {
                ComboBox comboBox = sender as ComboBox;


                string chosen = comboBox.SelectedItem.ToString();
                if (chosen != "none") {
                    dataGridView1.DataSource = tododoDB.todos.Where(s => s.type == chosen).ToList();
                } else {
                    LoadData();
                }


                /*
                switch (comboBox.SelectedIndex) {
                    case 0:
                        dataGridView1.DataSource = tododoDB.todos.Where(s => s.type == "education").ToList();
                        break;

                    case 1:
                        dataGridView1.DataSource = tododoDB.todos.Where(s => s.type == "recreational").ToList();
                        break;

                    case 2:
                        dataGridView1.DataSource = tododoDB.todos.Where(s => s.type == "social").ToList();
                        break;

                    case 3:
                        dataGridView1.DataSource = tododoDB.todos.Where(s => s.type == "diy").ToList();
                        break;

                    case 4:
                        dataGridView1.DataSource = tododoDB.todos.Where(s => s.type == "charity").ToList();
                        break;

                    case 5:
                        dataGridView1.DataSource = tododoDB.todos.Where(s => s.type == "cooking").ToList();
                        break;

                    case 6:
                        dataGridView1.DataSource = tododoDB.todos.Where(s => s.type == "relaxation").ToList();
                        break;

                    case 7:
                        dataGridView1.DataSource = tododoDB.todos.Where(s => s.type == "music").ToList();
                        break;

                    case 8:
                        dataGridView1.DataSource = tododoDB.todos.Where(s => s.type == "busywork").ToList();
                        break;
                }*/
            }
        }
    }

}
