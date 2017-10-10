using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Retail.Controls
{
    public class UserComboBox : System.Windows.Forms.ComboBox
    {
        /// <summary>
        /// 用户账号输入记录
        /// </summary>
        [XmlRoot("cmbUserName", IsNullable = false)]
        [Serializable]
        public class cmbUserName
        {
            [XmlAttribute("LastItem")]
            public string LastItem
            {
                get;
                set;
            }

            [XmlElement("Item")]
            public List<string> Items { get; set; }
        }

        private string XmlPath = System.Windows.Forms.Application.StartupPath + "\\SaveComboBox.xml";

        cmbUserName users;
        public UserComboBox()
        {
            try
            {
                if (File.Exists(XmlPath))
                {
                    using (StreamReader reader = new StreamReader(XmlPath))
                    {
                        System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(cmbUserName));
                        users = (cmbUserName)xmlSerializer.Deserialize(reader);
                        this.DataSource = users.Items;
                        this.Text = users.LastItem;
                    }
                }
            }
            catch
            {

            }
        }
        protected override void OnLeave(EventArgs e)
        {
            if (users == null)
            {
                users = new cmbUserName();
                users.LastItem = this.Text.Trim();
                users.Items = new List<string>();
                users.Items.Add(users.LastItem);
            }
            else
            {
                users.LastItem = this.Text.Trim();
                if (!users.Items.Contains(users.LastItem))
                {
                    users.Items.Add(users.LastItem);
                }
            }
            try
            {
                if (!string.IsNullOrWhiteSpace(XmlPath) && users != null)
                {
                    using (StreamWriter writer = new StreamWriter(XmlPath))
                    {
                        System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(users.GetType(), new XmlRootAttribute("cmbUserName"));
                        xmlSerializer.Serialize(writer, users);
                    }
                }
            }
            catch (Exception)
            {

            }
            base.OnLeave(e);
        }
    }
}
