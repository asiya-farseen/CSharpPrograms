using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace test2
{

    public class demo
    {
        public static void connecting()
        {
            //  string cs = "Data Source=FWS-LP-5156\\SQLSERVER2019;Initial Catalog=demodb2;Integrated Security=true;";
            // SqlConnection conn = new SqlConnection(cs);


            /* try
             {
                 Console.WriteLine("Openning Connection ...");

                 //open connection
                 conn.Open();

                 Console.WriteLine("Connection successful!");*/
            int opt;
            do
            {
                Console.Write("1-Add Player.\n2-Display Player.\n3- Add into the Matches \n 4-Delete Table\n5 Orange cap\n-Exit.\n");
                Console.Write("\nInput your choice :");
               // int opt;
                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        display();
                        break;
                    case 3:
                        addMatch();
                        break;
                    case 4:
                        delete();
                        break;
                     case 5:
                        OrangeCap();
                        break;
                    case 6:
                        break;


                }
            }
            while (opt != 6);
            
            }
        /*   catch (Exception e)
           {
               Console.WriteLine("Error: " + e.Message);
           }

           Console.Read();
       }*/

        public static void display()
        {
            string cs = "Data Source=FWS-LP-5156\\SQLSERVER2019;Initial Catalog=demodb3;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(cs);

            string queryDisplayPlayers = "SELECT * FROM iplPlayers";
            SqlCommand cmd = new SqlCommand(queryDisplayPlayers,conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("PlayerID\tPlayer Name\tMatches Played\tRuns Scored\tWickets Taken");
            while (dr.Read())
                Console.WriteLine(dr[0] + "\t\t" + dr[1] + "\t\t" + dr[2] + "\t\t" + dr[3] + "\t\t" + dr[4] + "\t");
        }
       public static void delete()

        {


            string cs = "Data Source=FWS-LP-5156\\SQLSERVER2019;Initial Catalog=demodb3;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(cs);

            Console.WriteLine("Enter player ID to delete:");
            int playerID = Convert.ToInt32(Console.ReadLine());

         

           
                    string queryDeletePlayer = "DELETE FROM iplPlayers WHERE playerID = @playerID";
                    SqlCommand cmd = new SqlCommand(queryDeletePlayer,conn);
                    cmd.Parameters.AddWithValue("@playerID", playerID);

                    string queryDeletePlayerFromMatches = "DELETE FROM iplMatches WHERE playerID = @playerID";
                    SqlCommand cmd1 = new SqlCommand(queryDeletePlayerFromMatches, conn);
                    cmd1.Parameters.AddWithValue("@playerID", playerID);

                    conn.Open();
                    int status1 = cmd1.ExecuteNonQuery();
                    int status = cmd.ExecuteNonQuery();
                    if (status > 0)
                        Console.WriteLine("Player deleted from players table successfully.");
                    else
                        Console.WriteLine("Player couldn't be deleted from players table. Try again after fixing errors or check your inputs.");
                    if (status1 > 0)
                        Console.WriteLine("Player deleted from matches table successfully.");
                    else
                        Console.WriteLine("Player couldn't be deleted from matches table. Try again after fixing errors or check your inputs.");
                }
            
        
    public static void add()
        {


            string cs = "Data Source=FWS-LP-5156\\SQLSERVER2019;Initial Catalog=demodb3;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(cs);


            Console.WriteLine("Enter the name of the player ");
            string playerName = Console.ReadLine();
            String query = "INSERT INTO iplplayers VALUES (@playerName,@matches,@runs,@wickets)";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@playerName", playerName);
            command.Parameters.AddWithValue("@matches", 0);
            command.Parameters.AddWithValue("@runs", 0);
            command.Parameters.AddWithValue("@wickets", 0);
            conn.Open();
            int i = command.ExecuteNonQuery();



            conn.Close();



            if (i != 0)
            {
                Console.WriteLine(i + "Data Saved");
            }


        }
        public static void OrangeCap()
        {



            string cs = "Data Source=FWS-LP-1230\\SQLSERVER2019;Initial Catalog=demodb2;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(cs);
            Console.WriteLine("Enter the year ");
            string year = Console.ReadLine();



            conn.Open();



            string query = "select top 1 playerid,sum(runs) as totalruns from iplmatches1 where year = 2022 group by playerid order by totalruns desc";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.Parameters.AddWithValue("@year", year);

            SqlDataReader dr = cmd1.ExecuteReader();
            Console.WriteLine("Playerid\tTotal Runs");
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");
        }

            public static void addMatch()
        {

            string cs = "Data Source=FWS-LP-5156\\SQLSERVER2019;Initial Catalog=demodb3;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(cs);


            Console.WriteLine("Enter the matches ID ");
            string matchID = Console.ReadLine();

            Console.WriteLine("Enter the name of the plyer ID ");
            string playerID = Console.ReadLine();

            Console.WriteLine("Enter the date of the match ");
            string matchDate = Console.ReadLine();
            Console.WriteLine("Enter the location of the match ");
            string location = Console.ReadLine();
            Console.WriteLine("Enter the runs ");
            string runs = Console.ReadLine();
            Console.WriteLine("Enter the wickets");
            string wickets = Console.ReadLine();
            Console.WriteLine("Enter the teamID");
            string teamID = Console.ReadLine();
            Console.WriteLine("Enter the year");
            string year = Console.ReadLine();
          
           
            String query = "INSERT INTO iplmatches VALUES (@matchID,@playerID,@matchDate,@location,@runs,@wickets,@year,@teamID)";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@matchID", matchID);
            command.Parameters.AddWithValue("@playerID", playerID);
            command.Parameters.AddWithValue("@matchDate", matchDate);
            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@runs", runs);
            command.Parameters.AddWithValue("@wickets", wickets);
            command.Parameters.AddWithValue("@teamID", teamID);
             command.Parameters.AddWithValue("@year", year);


           // string queryUpdatePlayer = "UPDATE iplplayers SET matches += 1, runs += @runs, wickets += @wickets WHERE playerId = @playerID";
           // SqlCommand cmd1 = new SqlCommand(queryUpdatePlayer, conn);

            string queryUpdatePlayer = "UPDATE iplplayers SET matches +=1 , runs += @runs, wickets += @wickets WHERE playerID = @playerID";
            SqlCommand cmd1 = new SqlCommand(queryUpdatePlayer, conn);
            cmd1.Parameters.AddWithValue("@matchID", matchID);
            cmd1.Parameters.AddWithValue("@playerID", playerID);
            cmd1.Parameters.AddWithValue("@runs", runs);
            cmd1.Parameters.AddWithValue("@wickets", wickets);

            conn.Open();
            //int status = command.ExecuteNonQuery();
            int status = command.ExecuteNonQuery();
            int status1 = cmd1.ExecuteNonQuery();
            
            if (status > 0)
                Console.WriteLine("Match added successfully.");
            else
                Console.WriteLine("Match couldn't be added. Try again after fixing errors or check your inputs.");
            if (status1 > 0)
                Console.WriteLine("Players table updated successfully.");
            else
                Console.WriteLine("Players table couldn't be updated. Try again after fixing errors or check your inputs.");
        }

        



                }
            }
        
        
                  

           