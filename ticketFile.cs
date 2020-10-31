
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ticketClass
{           //maybe add a field that specifies what type of ticket it is
            //maybe also add multible ticket lists, one for each type instead of one 
    class TicketFile
    {
        public TicketFile()
        {
            bugTickets = new List<bugTicket>();
            enhanceTickets = new List<enhanceTicket>();
            taskTickets = new List<taskTicket>();
        }
        public List<bugTicket> bugTickets { get; set; }
        public List<enhanceTicket> enhanceTickets { get; set; }
        public List<taskTicket> taskTickets { get; set; }
        public ulong count = 0;


        public void findBugTicket(string word, string field)
        {
            //recreate this method for each kind of ticket
            //recreate the add methods too
            if (field == "1")
            {
                IEnumerable<ticket> ticketTest = bugTickets.Where(t => t.status.Contains(word));

                foreach (ticket t in ticketTest)
                {
                    Console.WriteLine(t.Display());
                }
            }
            if (field == "2")
            {
                IEnumerable<ticket> ticketTest = bugTickets.Where(t => t.priority.Contains(word));

                foreach (ticket t in ticketTest)
                {
                    Console.WriteLine(t.Display());
                }
            }
            if (field == "3")
            {
                IEnumerable<ticket> ticketTest = bugTickets.Where(t => t.submitter.Contains(word));

                foreach (ticket t in ticketTest)
                {
                    Console.WriteLine(t.Display());
                }
            }



        }

        public void findEnhanceTicket(string word, string field)
        {
            //recreate this method for each kind of ticket
            //recreate the add methods too
            if (field == "1")
            {
                IEnumerable<ticket> ticketTest = enhanceTickets.Where(t => t.status.Contains(word));

                foreach (ticket t in ticketTest)
                {
                    Console.WriteLine(t.Display());
                }
            }
            if (field == "2")
            {
                IEnumerable<ticket> ticketTest = enhanceTickets.Where(t => t.priority.Contains(word));

                foreach (ticket t in ticketTest)
                {
                    Console.WriteLine(t.Display());
                }
            }
            if (field == "3")
            {
                IEnumerable<ticket> ticketTest = enhanceTickets.Where(t => t.submitter.Contains(word));

                foreach (ticket t in ticketTest)
                {
                    Console.WriteLine(t.Display());
                }
            }



        }

        public void findTaskTicket(string word, string field)
        {
            //recreate this method for each kind of ticket
            //recreate the add methods too
            if (field == "1")
            {
                IEnumerable<ticket> ticketTest = taskTickets.Where(t => t.status.Contains(word));

                foreach (ticket t in ticketTest)
                {
                    Console.WriteLine(t.Display());
                }
            }
            if (field == "2")
            {
                IEnumerable<ticket> ticketTest = taskTickets.Where(t => t.priority.Contains(word));

                foreach (ticket t in ticketTest)
                {
                    Console.WriteLine(t.Display());
                }
            }
            if (field == "3")
            {
                IEnumerable<ticket> ticketTest = taskTickets.Where(t => t.submitter.Contains(word));

                foreach (ticket t in ticketTest)
                {
                    Console.WriteLine(t.Display());
                }
            }



        }

        public void AddBugTicket(bugTicket bug)
        {
            bug.TicketId = bugTickets.Count() == 0 ? 1 : bugTickets.Max(b => b.TicketId) + 1;

            StreamWriter sw = new StreamWriter("bug.txt", true);

            sw.WriteLine($"{bug.TicketId},{bug.summary},{bug.status},{bug.priority},{bug.submitter},{bug.assigned},{bug.watching},{bug.severity}");
            sw.Close();

            bugTickets.Add(bug);
            sw.Close();


        }
        public void AddEnchanceTicket(enhanceTicket enh)
        {


            enh.TicketId = enhanceTickets.Count() == 0 ? 1 : enhanceTickets.Max(e => e.TicketId) + 1;


            StreamWriter sw = new StreamWriter("enh.txt", true);

            sw.WriteLine($"{enh.TicketId},{enh.summary},{enh.status},{enh.priority},{enh.submitter},{enh.assigned},{enh.watching},{enh.software},{enh.cost},{enh.reason},{enh.estimate}");
            sw.Close();

            enhanceTickets.Add(enh);
            sw.Close();


        }
        public void AddTaskTicket(taskTicket task)
        {


            task.TicketId = taskTickets.Count() == 0 ? 1 : taskTickets.Max(t => t.TicketId) + 1;


            StreamWriter sw = new StreamWriter("task.txt", true);

            sw.WriteLine($"{task.TicketId},{task.summary},{task.status},{task.priority},{task.submitter},{task.assigned},{task.watching},{task.projectName},{task.dueDate}");
            sw.Close();

            taskTickets.Add(task);
            sw.Close();
        }
        public void readTicket()
        {
            StreamReader sr = new StreamReader("bug.txt");
            while (!sr.EndOfStream)
            {
                string lineOfCode = sr.ReadLine();
                string[] parsedLineOfCode = lineOfCode.Split(',');

                bugTicket bTicket = new bugTicket
                {
                    TicketId = ulong.Parse(parsedLineOfCode[0]),
                    summary = parsedLineOfCode[1],
                    status = parsedLineOfCode[2],
                    priority = parsedLineOfCode[3],
                    submitter = parsedLineOfCode[4],
                    assigned = parsedLineOfCode[5],
                    watching = parsedLineOfCode[6],
                    severity = parsedLineOfCode[7],
                };
                bugTickets.Add(bTicket);
            }
            sr.Close();

            StreamReader srr = new StreamReader("enh.txt");
            while (!srr.EndOfStream)
            {
                string lineOfCode = srr.ReadLine();
                string[] parsedLineOfCode = lineOfCode.Split(',');

                enhanceTicket eTicket = new enhanceTicket
                {
                    TicketId = ulong.Parse(parsedLineOfCode[0]),
                    summary = parsedLineOfCode[1],
                    status = parsedLineOfCode[2],
                    priority = parsedLineOfCode[3],
                    submitter = parsedLineOfCode[4],
                    assigned = parsedLineOfCode[5],
                    watching = parsedLineOfCode[6],
                    software = parsedLineOfCode[7],
                    cost = parsedLineOfCode[8],
                    reason = parsedLineOfCode[7],
                    estimate = parsedLineOfCode[9],
                };
                enhanceTickets.Add(eTicket);
            }
            srr.Close();

            StreamReader srrr = new StreamReader("task.txt");
            while (!srrr.EndOfStream)
            {
                string lineOfCode = srrr.ReadLine();
                string[] parsedLineOfCode = lineOfCode.Split(',');

                taskTicket tTicket = new taskTicket
                {
                    TicketId = ulong.Parse(parsedLineOfCode[0]),
                    summary = parsedLineOfCode[1],
                    status = parsedLineOfCode[2],
                    priority = parsedLineOfCode[3],
                    submitter = parsedLineOfCode[4],
                    assigned = parsedLineOfCode[5],
                    watching = parsedLineOfCode[6],
                    projectName = parsedLineOfCode[7],
                    dueDate = parsedLineOfCode[8],

                };
                taskTickets.Add(tTicket);
            }
            srrr.Close();
        }


        public void displayTickets()
        {
            for (int x = 0; x < bugTickets.Count; x++)
            {
                Console.WriteLine(bugTickets[x].Display());
            }
            for (int x = 0; x < enhanceTickets.Count; x++)
            {
                Console.WriteLine(enhanceTickets[x].Display());
            }
            for (int x = 0; x < taskTickets.Count; x++)
            {
                Console.WriteLine(taskTickets[x].Display());
            }
        }
    }
}
