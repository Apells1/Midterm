using System;
using System.IO;
using System.Collections;
namespace midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            string userchoice = "";
            string userchoice2 = "";
            ticketClass.TicketFile tk = new ticketClass.TicketFile();
            tk.readTicket();
            do
            {
                Console.WriteLine("please type 1 to add a ticket to a file, 2 to read all tickets, 3 to search for a ticket or any other character to quit");
                userchoice = Console.ReadLine();

                if (userchoice == "1")
                {

                    Console.WriteLine("press 1 to create a bug ticket, 2 to create a enchancment ticket or 3 to create a task ticket");
                    userchoice2 = Console.ReadLine();

                    if (userchoice2 == "1")
                    {
                        Console.WriteLine("Please enter the ticket summary");
                        string summary2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket status");
                        string status2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket priority");
                        string priority2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket submitter");
                        string submitter2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket assigner");
                        string assigned2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket watchers");
                        string watching2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket severity");
                        string severity2 = Console.ReadLine();

                        ticketClass.bugTicket bt = new ticketClass.bugTicket
                        {
                            summary = summary2,
                            status = status2,
                            priority = priority2,
                            submitter = submitter2,
                            assigned = assigned2,
                            watching = watching2,
                            severity = severity2
                        };
                        tk.AddBugTicket(bt);
                    }
                    if (userchoice2 == "2")
                    {
                        Console.WriteLine("Please enter the ticket summary");
                        string summary2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket status");
                        string status2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket priority");
                        string priority2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket submitter");
                        string submitter2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket assigner");
                        string assigned2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket watchers");
                        string watching2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket software");
                        string software2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket cost");
                        string cost2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket reason");
                        string reason2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket estimate");
                        string estimate2 = Console.ReadLine();



                        ticketClass.enhanceTicket et = new ticketClass.enhanceTicket
                        {
                            summary = summary2,

                            status = status2,

                            priority = priority2,

                            submitter = submitter2,

                            assigned = assigned2,

                            watching = watching2,

                            software = software2,

                            cost = cost2,

                            reason = reason2,

                            estimate = estimate2
                        };
                        tk.AddEnchanceTicket(et);
                    }
                    if (userchoice2 == "3")
                    {
                        Console.WriteLine("Please enter the ticket summary");
                        string summary2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket status");
                        string status2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket priority");
                        string priority2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket submitter");
                        string submitter2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket assigner");
                        string assigned2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket watchers");
                        string watching2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket project name");
                        string projectName2 = Console.ReadLine();
                        Console.WriteLine("Please enter the ticket due date");
                        string dueDate2 = Console.ReadLine();




                        ticketClass.taskTicket tt = new ticketClass.taskTicket
                        {
                            summary = summary2,

                            status = status2,

                            priority = priority2,

                            submitter = submitter2,

                            assigned = assigned2,

                            watching = watching2,

                            projectName = projectName2,

                            dueDate = dueDate2
                        };
                        tk.AddTaskTicket(tt);
                    }


                }
                if (userchoice == "2")
                {

                    tk.displayTickets();
                }
                if (userchoice == "3")
                {
                    Console.WriteLine("Press 1 to search for bugs, 2 to search for enhance or 3 to search by task");
                    string type = Console.ReadLine();
                    Console.WriteLine("Press 1 to search by status, 2 to search by priority or 3 to search by submitter");
                    string userChoice3 = Console.ReadLine();
                    Console.WriteLine("please enter the value you wish to search by");
                    string searchBar = Console.ReadLine();
                    if (type == "1")
                    {
                        tk.findBugTicket(searchBar, userChoice3);
                    }
                    if (type == "2")
                    {
                        tk.findEnhanceTicket(searchBar, userChoice3);
                    }
                    if (type == "3")
                    {
                        tk.findTaskTicket(searchBar, userChoice3);
                    }


                }



            }

            while (userchoice == "1" || userchoice == "2" || userchoice == "3");
        }
    }
}
