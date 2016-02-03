using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyData.Resources
{
    class Tools
    {

        public DataTable SqlAdapter(string items, string data, string extra)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Resources\Databasen.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select " + items + " FROM [" + data + "] " + extra, con);
            DataSet ds = new DataSet();
            adap.Fill(ds, data);

            return ds.Tables[0];
        }

        public DataTable SqlDeleteColor(string family, string color)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Resources\Databasen.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("DELETE FROM [Tekstil.Color] WHERE Family='" + family + "' AND Color='" + color + "'", con);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Tekstil.Color");

            return ds.Tables[0];
        }

        public string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "-", RegexOptions.Compiled);
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public bool SearchConfig(string sku)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Resources\Databasen.mdf;Integrated Security=True";
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select Type FROM [Tekstil.Content] WHERE (SKU = '" + sku + "' AND Type = 'Configurable')", con);
            DataSet ds = new DataSet();
            adap.Fill(ds, "[Tekstil.Content]");

            if (ds.Tables[0].Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string CreateConfigurable(string name, string family, string sku, string price, string desciption, List<string> simples)
        {
            try
            {
                string categori;
                switch (family)
                {
                    case "T-Shirt":
                        categori = "1197";
                        break;
                    case "Stormtech":
                        categori = "1199";
                        break;
                    case "Poloer":
                        categori = "1200";
                        break;
                    case "Sweatshirts":
                        categori = "1202";
                        break;
                    case "Skjorter":
                        categori = "1203";
                        break;
                    case "Jakker":
                        categori = "1204";
                        break;
                    case "Caps":
                        categori = "1206";
                        break;
                    case "Tasker":
                        categori = "1207";
                        break;
                    case "Poser":
                        categori = "1208";
                        break;
                    case "Paraplyer":
                        categori = "1209";
                        break;
                    case "Diverse":
                        categori = "1210";
                        break;
                    case "Sport":
                        categori = "1219";
                        break;
                    case "Bodywarmer":
                        categori = "1221";
                        break;
                    case "Fleece":
                        categori = "1222";
                        break;
                    case "Stormtech - Overtøj - Teknisk":
                        categori = "1199,1211";
                        family = "Stormtech";
                        break;
                    case "Stormtech - Overtøj - Thermo":
                        categori = "1199,1212";
                        family = "Stormtech";
                        break;
                    case "Stormtech - Lightweight":
                        categori = "1199,1216";
                        family = "Stormtech";
                        break;
                    case "Stormtech - System Jakker":
                        categori = "1199,1213";
                        family = "Stormtech";
                        break;
                    case "Stormtech - Workwear":
                        categori = "1199,1214";
                        family = "Stormtech";
                        break;
                    case "Stormtech - Corporate":
                        categori = "1199,1220";
                        family = "Stormtech";
                        break;
                    case "Stormtech - Performance - Fleece":
                        categori = "1199,1215";
                        family = "Stormtech";
                        break;
                    case "Stormtech - Performance - Poloer":
                        categori = "1199,1217";
                        family = "Stormtech";
                        break;
                    case "Stormtech - Performance - Athletic":
                        categori = "1199,1218";
                        family = "Stormtech";
                        break;
                    case "Stormtech - Tasker":
                        categori = "1199,1223";
                        family = "Stormtech";
                        break;
                    default:
                        categori = "0";
                        break;
                }

                string configurable = Properties.Resources.configurable;

                var newsku = sku + "-" + family.Replace(" ", "-").ToLower() + "-" + RemoveSpecialCharacters(name.Replace("/", "-")).ToLower();
                string simple = "";

                int simco = simples.Count;
                int simcos = 0;

                foreach (string lines in simples)
                {
                    simcos++;

                    if (simcos != simco)
                    {
                        simple += lines + ",";
                    }
                    else
                    {
                        simple += lines;
                    }
                }

                string line = configurable.Replace(@"XNAME", name).Replace(@"XSKU", newsku).Replace(@"XFAMILY", family).Replace(@"XCAT", categori.ToString()).Replace(@"XDESCS", desciption).Replace(@"XDESCL", Regex.Replace(desciption, @"\r\n?|\n", "<br>\n")).Replace(@"XPRICE", price).Replace(@"XSIMPLE", simple).Replace(@"XFAS",family.ToLower());

                return line.Replace("--","-");

            }
            catch (Exception ev)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ev.Message);

                return ev.Message;
            }
        }

        public string CreateSimple(string name, string family, string color, string size, string gender, string sku)
        {
            try
            {
                string simple = Properties.Resources.simple;
                var newsku = "";

                if (family.Contains("Stormtech"))
                {
                    family = "Stormtech";
                }

                if (name.Length > 20)
                {
                    newsku = sku + "-" + family.Replace(" ", "-").ToLower() + "-" + RemoveSpecialCharacters(name.Substring(0, 20)).ToLower() + "-" + color.Replace(" ", "-").Replace("/", "-").ToLower() + "-" + RemoveSpecialCharacters(size).ToLower();
                }
                else
                {
                    newsku = sku + "-" + family.Replace(" ", "-").ToLower() + "-" + RemoveSpecialCharacters(name).ToLower() + "-" + color.Replace(" ", "-").Replace("/", "-").ToLower() + "-" + RemoveSpecialCharacters(size).ToLower();
                }

                if (newsku.Length > 64)
                {
                    newsku = newsku.Substring(0, 64);
                }

                string line = simple.Replace(@"XNAME", name).Replace(@"XCOLOR", color).Replace(@"XSIZE", size).Replace(@"XGENDER", gender).Replace(@"XFAMILY", family).Replace(@"XSKU", newsku);

                return line.Replace("--","-");
            }
            catch (Exception ev)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ev.Message);

                return ev.Message;
            }
        }

        public string CurrencyConvert(int curr, string value)
        {
            string amount = "";
            decimal val = decimal.Parse(value,new NumberFormatInfo() { NumberDecimalSeparator = "." });

            switch (curr)
            {
                case 0:
                    amount = value.ToString();
                    break;

                case 1:
                    amount = Math.Ceiling((val * Properties.Settings.Default.EUR)).ToString();
                    break;

                case 2:
                    amount = Math.Ceiling((val * Properties.Settings.Default.GBP)).ToString();
                    break;

                default:
                    amount = value.ToString();
                    break;
            }

            return amount;
        }
    }
}
