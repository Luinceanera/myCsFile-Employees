using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Employees
{
    class Control
    {
        /* File */
        string fileLocation = "Employee List.txt";
        /* Transport */
        View v = new View();
        /* Control */
        private bool b0;
        private bool b1;
        private bool b2;
        private bool b3;
        private char c0;
        private char c1;
        private int i0;
        private int i1;
        /* International */
        char[] ANSW = new char[10000];
        string[] CFET = new string[10000];
        string[] CATG = new string[10000];
        int[] CSTM = new int[10000];
        string[] DEPT = new string[10000];
        string[] FSTN = new string[10000];
        int[] FOOD = new int[10000];
        int[] IDEN = new int[10000];
        string[] LSTN = new string[10000];
        char[] OPER = new char[10000];
        int[] PATI = new int[10000];
        string[] SPEC = new string[10000];
        char[] SWEP = new char[10000];
        /* Temporary */
        char tANSW;
        string tCFET;
        string tCATG;
        int tCSTM;
        string tDEPT;
        string tFSTN;
        int tFOOD;
        int tIDEN;
        string tLSTN;
        char tOPER;
        int tPATI;
        string tSPEC;
        char tSWEP;
        public void LoadFile()
        {
            for (int index = 0; index < IDEN.Length; index++)
            {
                IDEN[index] = -1;
            }
            String input = File.ReadAllText(fileLocation);
            /*
            string[] sIDEN = new string[10000];
            int i = 0, j = 0;
            string[,] result = new string[10, 10];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    result[i, j] = col.Trim();
                    j++;
                }
                i++;
            }
            for (int a = 0; a < i; a++)
            {
                int.TryParse(result[a, 0], out IDEN[a]);
                CATG[a] = result[a, 1];
                LSTN[a] = result[a, 2];
                FSTN[a] = result[a, 3];
                if (CATG[a] == "ADM" || CATG[a] == "JAN" || CATG[a] == "REC")
                {
                    DEPT[a] = result[a, 4];
                    if (CATG[a] == "JAN")
                    {
                        char.TryParse(result[a, 5], out SWEP[a]);
                    }
                    else if (CATG[a] == "REC")
                    {
                        char.TryParse(result[a, 5], out ANSW[a]);
                    }
                }
                else if (CATG[a] == "CFM" || CATG[a] == "CHF" || CATG[a] == "WTR")
                {
                    CFET[a] = result[a, 4];
                    if (CATG[a] == "CHF")
                    {
                        int.TryParse(result[a, 5], out FOOD[a]);
                    }
                    else if (CATG[a] == "WTR")
                    {
                        int.TryParse(result[a, 5], out CSTM[a]);
                    }
                }
                else if (CATG[a] == "DOC" || CATG[a] == "SGT")
                {
                    SPEC[a] = result[a, 4];
                    if (CATG[a] == "SGT")
                    {
                        char.TryParse(result[a, 5], out OPER[a]);
                    }
                }
                else if (CATG[a] == "NRS")
                {
                    int.TryParse(result[a, 4], out PATI[a]);
                }
            }
            Console.WriteLine(IDEN[0]);*/
            List<Items> items = new List<Items>();
            List<string> lines = File.ReadAllLines(fileLocation).ToList();
            int xo = 0;
            foreach (var line in lines)
            {
                string[] entries = line.Split(' ');
                CATG[xo] = entries[0];
                IDEN[xo] = int.Parse(entries[1]);
                LSTN[xo] = entries[2];
                FSTN[xo] = entries[3];
                if (CATG[xo] == "ADM" || CATG[xo] == "JAN" || CATG[xo] == "REC")
                {
                    DEPT[xo] = entries[4];
                    if (CATG[xo] == "JAN")
                    {
                        SWEP[xo] = char.Parse(entries[5]);
                    }
                    else if (CATG[xo] == "REC")
                    {
                        ANSW[xo] = char.Parse(entries[5]);
                    }
                }
                else if (CATG[xo] == "CFM" || CATG[xo] == "CHF" || CATG[xo] == "WTR")
                {
                    CFET[xo] = entries[4];
                    if (CATG[xo] == "CHF")
                    {
                        FOOD[xo] = int.Parse(entries[5]);
                    }
                    else if (CATG[xo] == "REC")
                    {
                        CSTM[xo] = int.Parse(entries[5]);
                    }
                }
                else if (CATG[xo] == "DOC" || CATG[xo] == "SGT")
                {
                    SPEC[xo] = entries[4];
                    if (CATG[xo] == "SGT")
                    {
                        OPER[xo] = char.Parse(entries[5]);
                    }
                }
                else if (CATG[xo] == "NRS")
                {
                    PATI[xo] = int.Parse(entries[4]);
                }
                xo++;
            }
            MainMenu();
        }
        public void Reset()
        {
            tANSW = '\0';
            tCFET = "\0";
            tCATG = "\0";
            tCSTM = 0;
            tDEPT = "\0";
            tFSTN = "\0";
            tFOOD = 0;
            tIDEN = 0;
            tLSTN = "\0";
            tOPER = '\0';
            tPATI = 0;
            tSPEC = "\0";
            tSWEP = '\0';
        }
        public void MainMenu()
        {
            b0 = false;
            while (b0 == false)
            {
                b1 = false;
                while (b1 == false)
                {
                    Console.WriteLine();
                    v.Frame("==");
                    Console.WriteLine("MAIN");
                    v.Frame("==");
                    v.MainMenu();
                    int.TryParse(Console.ReadLine(), out i0);
                    if (i0 < 6 && i0 > -1)
                    {
                        b1 = true;
                    }
                    else
                    {
                        Console.WriteLine(Error(0));
                    }
                }
                switch (i0)
                {
                    case 0:
                        b0 = true;
                        break;
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        DropEmployee();
                        break;
                    case 3:
                        ModifyEmployee();
                        break;
                    case 4:
                        SaveEmployees();
                        break;
                    case 5:
                        ViewEmployees();
                        break;
                }
            }
        }
        public void AddEmployee()
        {
            b1 = false;
            while (b1 == false)
            {
                b2 = false;
                while (b2 == false)
                {
                    Console.WriteLine();
                    v.Frame("==");
                    Console.WriteLine("MAIN >> ADD");
                    v.Frame("==");
                    v.AddEmployee();
                    int.TryParse(Console.ReadLine(), out i1);
                    if (i1 < 11 && i1 > -1)
                    {
                        b2 = true;
                    }
                    else
                    {
                        Console.WriteLine(Error(0));
                    }
                }
                int a = 0;
                while (IDEN[a] != -1)
                {
                    a++;
                }
                switch (i1)
                {
                    case 0:
                        b1 = true;
                        break;
                    case 1:
                        b2 = false;
                        b3 = false;
                        while (b2 == false)
                        {
                            Reset();
                            while (b3 == false)
                            {
                                b3 = true;
                                for (int index = 0; IDEN[index] != -1; index++)
                                {
                                    if (tIDEN == IDEN[index])
                                    {
                                        b3 = false;
                                    }
                                }
                                if (b3 == false)
                                {
                                    tIDEN++;
                                }
                            }
                            Console.WriteLine("[1/3] Please Enter the Last Name: ");
                            tLSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[2/3] Please Enter the First Name: ");
                            tFSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[3/3] Please Enter the Department: ");
                            tDEPT = Console.ReadLine();
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("SUMMARY");
                                Console.WriteLine();
                                Administrator admin = new Administrator(tIDEN, tLSTN, tFSTN, tDEPT);
                                admin.Detail();
                                Console.Write("Is this correct? (Y/N):");
                                Char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    b3 = true;
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else if (c0 == 'n')
                                    {
                                        c0 = 'N';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            if (c0 == 'Y')
                            {
                                CATG[a] = "ADM";
                                IDEN[a] = tIDEN;
                                LSTN[a] = tLSTN;
                                FSTN[a] = tFSTN;
                                DEPT[a] = tDEPT;
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("What would you like to do?");
                                Console.WriteLine("1 - Create Another Administrator");
                                Console.WriteLine("2 - Create Another Employee");
                                Console.WriteLine("3 - Return to Main Menu");
                                int.TryParse(Console.ReadLine(), out i0);
                                if (i0 > 0 && i0 < 4)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            if (i0 == 2)
                            {
                                b2 = true;
                            }
                            else if (i0 == 3)
                            {
                                b1 = true;
                                b2 = true;
                            }
                        }
                        break;
                    case 2:
                        b2 = false;
                        b3 = false;
                        while (b2 == false)
                        {
                            Reset();
                            while (b3 == false)
                            {
                                b3 = true;
                                for (int index = 0; index < IDEN.Length; index++)
                                {
                                    if (tIDEN == IDEN[index])
                                    {
                                        b3 = false;
                                    }
                                }
                                if (b3 == false)
                                {
                                    tIDEN++;
                                }
                            }
                            Console.WriteLine("[1/3] Please Enter the Last Name: ");
                            tLSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[2/3] Please Enter the First Name: ");
                            tFSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[3/3] Please Enter the Café Type: ");
                            tCFET = Console.ReadLine();
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("SUMMARY");
                                Console.WriteLine();
                                CafeManager manage = new CafeManager(tIDEN, tLSTN, tFSTN, tCFET);
                                manage.Detail();
                                Console.Write("Is this correct? (Y/N):");
                                Char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    b3 = true;
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else if (c0 == 'n')
                                    {
                                        c0 = 'N';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            if (c0 == 'Y')
                            {
                                
                                CATG[a] = "CFM";
                                IDEN[a] = tIDEN;
                                LSTN[a] = tLSTN;
                                FSTN[a] = tFSTN;
                                CFET[a] = tCFET;
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("What would you like to do?");
                                Console.WriteLine("1 - Create Another Café Manager");
                                Console.WriteLine("2 - Create Another Employee");
                                Console.WriteLine("3 - Return to Main Menu");
                                int.TryParse(Console.ReadLine(), out i0);
                                if (i0 > 0 && i0 < 4)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            if (i0 == 2)
                            {
                                b2 = true;
                            }
                            else if (i0 == 3)
                            {
                                b1 = true;
                                b2 = true;
                            }
                        }
                        break;
                    case 3:
                        b2 = false;
                        b3 = false;
                        while (b2 == false)
                        {
                            Reset();
                            while (b3 == false)
                            {
                                b3 = true;
                                for (int index = 0; index < IDEN.Length; index++)
                                {
                                    if (tIDEN == IDEN[index])
                                    {
                                        b3 = false;
                                    }
                                }
                                if (b2 == false)
                                {
                                    tIDEN++;
                                }
                            }
                            Console.WriteLine("[1/4] Please Enter the Last Name: ");
                            tLSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[2/4] Please Enter the First Name: ");
                            tFSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[3/4] Please Enter the Café Type: ");
                            tCFET = Console.ReadLine();
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("[4/4] How many Food(s) Pepared?");
                                int.TryParse(Console.ReadLine(), out tFOOD);
                                if (tFOOD >= 0)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("SUMMARY");
                                Console.WriteLine();
                                Chef chef = new Chef(tIDEN, tLSTN, tFSTN, tCFET, tFOOD);
                                chef.Detail();
                                Console.Write("Is this correct? (Y/N):");
                                Char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    b3 = true;
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else
                                    {
                                        c0 = 'N';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            if (c0 == 'Y')
                            {
                                
                                CATG[a] = "CHF";
                                IDEN[a] = tIDEN;
                                LSTN[a] = tLSTN;
                                FSTN[a] = tFSTN;
                                CFET[a] = tCFET;
                                FOOD[a] = tFOOD;
                            }
                        }
                        b3 = false;
                        while (b3 == false)
                        {
                            Console.WriteLine("What would you like to do?");
                            Console.WriteLine("1 - Create Another Chef");
                            Console.WriteLine("2 - Create Another Employee");
                            Console.WriteLine("3 - Return to Main Menu");
                            int.TryParse(Console.ReadLine(), out i0);
                            if (i0 > 0 && i0 < 4)
                            {
                                b3 = true;
                            }
                            else
                            {
                                Console.WriteLine(Error(0));
                            }
                        }
                        if (i0 == 2)
                        {
                            b2 = true;
                        }
                        else if (i0 == 3)
                        {
                            b1 = true;
                            b2 = true;
                        }
                        break;
                    case 4:
                        b2 = false;
                        b3 = false;
                        while (b2 == false)
                        {
                            Reset();
                            while (b3 == false)
                            {
                                b3 = true;
                                for (int index = 0; index < IDEN.Length; index++)
                                {
                                    if (tIDEN == IDEN[index])
                                    {
                                        b3 = false;
                                    }
                                }
                                if (b3 == false)
                                {
                                    tIDEN++;
                                }
                            }
                            Console.WriteLine("[1/3] Please Enter the Last Name: ");
                            tLSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[2/3] Please Enter the First Name: ");
                            tFSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[3/3] Please Enter the Specialty: ");
                            tSPEC = Console.ReadLine();
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("SUMMARY");
                                Console.WriteLine();
                                Doctor doctor = new Doctor(tIDEN, tLSTN, tFSTN, tSPEC);
                                doctor.Detail();
                                Console.Write("Is this correct? (Y/N):");
                                Char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    b3 = true;
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else
                                    {
                                        c0 = 'N';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            if (c0 == 'Y')
                            {
                                
                                CATG[a] = "DOC";
                                IDEN[a] = tIDEN;
                                LSTN[a] = tLSTN;
                                FSTN[a] = tFSTN;
                                SPEC[a] = tSPEC;
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("What would you like to do?");
                                Console.WriteLine("1 - Create Another Doctor");
                                Console.WriteLine("2 - Create Another Employee");
                                Console.WriteLine("3 - Return to Main Menu");
                                int.TryParse(Console.ReadLine(), out i0);
                                if (i0 > 0 && i0 < 4)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            if (i0 == 2)
                            {
                                b2 = true;
                            }
                            else if (i0 == 3)
                            {
                                b1 = true;
                                b2 = true;
                            }
                        }
                        break;
                    case 5:
                        b2 = false;
                        b3 = false;
                        while (b2 == false)
                        {
                            Reset();
                            while (b3 == false)
                            {
                                b3 = true;
                                for (int index = 0; index < IDEN.Length; index++)
                                {
                                    if (tIDEN == IDEN[index])
                                    {
                                        b3 = false;
                                    }
                                }
                                if (b3 == false)
                                {
                                    tIDEN++;
                                }
                            }
                            Console.WriteLine("[1/2] Please Enter the Last Name: ");
                            tLSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[2/2] Please Enter the First Name: ");
                            tFSTN = Console.ReadLine();
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("SUMMARY");
                                Console.WriteLine();
                                HospitalEmployee hospital = new HospitalEmployee(tIDEN, tLSTN, tFSTN);
                                hospital.Detail();
                                Console.Write("Is this correct? (Y/N):");
                                Char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    b3 = true;
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else
                                    {
                                        c0 = 'N';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            if (c0 == 'Y')
                            {
                                
                                CATG[a] = "HOS";
                                IDEN[a] = tIDEN;
                                LSTN[a] = tLSTN;
                                FSTN[a] = tFSTN;
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("What would you like to do?");
                                Console.WriteLine("1 - Create Another Hospital Employee");
                                Console.WriteLine("2 - Create Another Employee");
                                Console.WriteLine("3 - Return to Main Menu");
                                int.TryParse(Console.ReadLine(), out i0);
                                if (i0 > 0 && i0 < 4)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            if (i0 == 2)
                            {
                                b2 = true;
                            }
                            else if (i0 == 3)
                            {
                                b1 = true;
                                b2 = true;
                            }
                        }
                        break;
                    case 6:
                        b2 = false;
                        b3 = false;
                        while (b2 == false)
                        {
                            Reset();
                            while (b3 == false)
                            {
                                b3 = true;
                                for (int index = 0; index < IDEN.Length; index++)
                                {
                                    if (tIDEN == IDEN[index])
                                    {
                                        b3 = false;
                                    }
                                }
                                if (b3 == false)
                                {
                                    tIDEN++;
                                }
                            }
                            Console.WriteLine("[1/4] Please Enter the Last Name: ");
                            tLSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[2/4] Please Enter the First Name: ");
                            tFSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[3/4] Please Enter the Department: ");
                            tDEPT = Console.ReadLine();
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.Write("[4/4] Sweeps? (Y/N): ");
                                Char.TryParse(Console.ReadLine(), out tSWEP);
                                if (tSWEP == 'Y' || tSWEP == 'y' || tSWEP == 'N' || tSWEP == 'n')
                                {
                                    if (tSWEP == 'y')
                                    {
                                        tSWEP = 'Y';
                                    }
                                    else
                                    {
                                        tSWEP = 'N';
                                    }
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("SUMMARY");
                                Console.WriteLine();
                                Janitor janitor = new Janitor(tIDEN, tLSTN, tFSTN, tDEPT, tSWEP);
                                janitor.Detail();
                                Console.Write("Is this correct? (Y/N):");
                                Char.TryParse(Console.ReadLine(), out c1);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    b3 = true;
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else
                                    {
                                        c0 = 'N';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            if (c0 == 'Y')
                            {
                                
                                CATG[a] = "JAN";
                                IDEN[a] = tIDEN;
                                LSTN[a] = tLSTN;
                                FSTN[a] = tFSTN;
                                DEPT[a] = tDEPT;
                                SWEP[a] = tSWEP;
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("What would you like to do?");
                                Console.WriteLine("1 - Create Another Janitor");
                                Console.WriteLine("2 - Create Another Employee");
                                Console.WriteLine("3 - Return to Main Menu");
                                int.TryParse(Console.ReadLine(), out i0);
                                if (i0 > 0 && i0 < 4)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            if (i0 == 2)
                            {
                                b2 = true;
                            }
                            else if (i0 == 3)
                            {
                                b1 = true;
                                b2 = true;
                            }
                        }
                        break;
                    case 7:
                        b2 = false;
                        b3 = false;
                        while (b2 == false)
                        {
                            Reset();
                            while (b3 == false)
                            {
                                b3 = true;
                                for (int index = 0; index < IDEN.Length; index++)
                                {
                                    if (tIDEN == IDEN[index])
                                    {
                                        b3 = false;
                                    }
                                }
                                if (b3 == false)
                                {
                                    tIDEN++;
                                }
                            }
                            Console.WriteLine("[1/3] Please Enter the Last Name: ");
                            tLSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[2/3] Please Enter the First Name: ");
                            tFSTN = Console.ReadLine();
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("[3/3] How many Patient(s)?");
                                int.TryParse(Console.ReadLine(), out tPATI);
                                if (tPATI >= 0)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("SUMMARY");
                                Console.WriteLine();
                                Nurse nurse = new Nurse(tIDEN, tLSTN, tFSTN, tPATI);
                                nurse.Detail();
                                Console.Write("Is this correct? (Y/N):");
                                Char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    b3 = true;
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else
                                    {
                                        c0 = 'N';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            if (c0 == 'Y')
                            {
                                
                                CATG[a] = "NRS";
                                IDEN[a] = tIDEN;
                                LSTN[a] = tLSTN;
                                FSTN[a] = tFSTN;
                                PATI[a] = tPATI;
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("What would you like to do?");
                                Console.WriteLine("1 - Create Another Nurse");
                                Console.WriteLine("2 - Create Another Employee");
                                Console.WriteLine("3 - Return to Main Menu");
                                int.TryParse(Console.ReadLine(), out i0);
                                if (i0 > 0 && i0 < 4)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            if (i0 == 2)
                            {
                                b2 = true;
                            }
                            else if (i0 == 3)
                            {
                                b1 = true;
                                b2 = true;
                            }
                        }
                        break;
                    case 8:
                        b2 = false;
                        b3 = false;
                        while (b2 == false)
                        {
                            Reset();
                            while (b3 == false)
                            {
                                b3 = true;
                                for (int index = 0; index < IDEN.Length; index++)
                                {
                                    if (tIDEN == IDEN[index])
                                    {
                                        b3 = false;
                                    }
                                }
                                if (b3 == false)
                                {
                                    tIDEN++;
                                }
                            }
                            Console.WriteLine("[1/4] Please Enter the Last Name: ");
                            tLSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[2/4] Please Enter the First Name: ");
                            tFSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[3/4] Please Enter the Department: ");
                            tDEPT = Console.ReadLine();
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.Write("[4/4] Answer Calls? (Y/N): ");
                                Char.TryParse(Console.ReadLine(), out tANSW);
                                if (tANSW == 'Y' || tANSW == 'y' || tANSW == 'N' || tANSW == 'n')
                                {
                                    if (tANSW == 'y')
                                    {
                                        tANSW = 'Y';
                                    }
                                    else
                                    {
                                        tANSW = 'N';
                                    }
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("SUMMARY");
                                Console.WriteLine();
                                Receptionist reception = new Receptionist(tIDEN, tLSTN, tFSTN, tDEPT, tANSW);
                                reception.Detail();
                                Console.Write("Is this correct? (Y/N):");
                                Char.TryParse(Console.ReadLine(), out c1);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    b3 = true;
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else
                                    {
                                        c0 = 'N';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            if (c0 == 'Y')
                            {
                                
                                CATG[a] = "REC";
                                IDEN[a] = tIDEN;
                                LSTN[a] = tLSTN;
                                FSTN[a] = tFSTN;
                                DEPT[a] = tDEPT;
                                ANSW[a] = tANSW;
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("What would you like to do?");
                                Console.WriteLine("1 - Create Another Receptionist");
                                Console.WriteLine("2 - Create Another Employee");
                                Console.WriteLine("3 - Return to Main Menu");
                                int.TryParse(Console.ReadLine(), out i0);
                                if (i0 > 0 && i0 < 4)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            if (i0 == 2)
                            {
                                b2 = true;
                            }
                            else if (i0 == 3)
                            {
                                b1 = true;
                                b2 = true;
                            }
                        }
                        break;
                    case 9:
                        b2 = false;
                        b3 = false;
                        while (b2 == false)
                        {
                            Reset();
                            while (b3 == false)
                            {
                                b3 = true;
                                for (int index = 0; index < IDEN.Length; index++)
                                {
                                    if (tIDEN == IDEN[index])
                                    {
                                        b3 = false;
                                    }
                                }
                                if (b3 == false)
                                {
                                    tIDEN++;
                                }
                            }
                            Console.WriteLine("[1/4] Please Enter the Last Name: ");
                            tLSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[2/4] Please Enter the First Name: ");
                            tFSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[3/4] Please Enter the Specialty: ");
                            tSPEC = Console.ReadLine();
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.Write("[4/4] Operates? (Y/N): ");
                                Char.TryParse(Console.ReadLine(), out tOPER);
                                if (tOPER == 'Y' || tOPER == 'y' || tOPER == 'N' || tOPER == 'n')
                                {
                                    if (tOPER == 'y')
                                    {
                                        tOPER = 'Y';
                                    }
                                    else
                                    {
                                        tOPER = 'N';
                                    }
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            while (b3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("SUMMARY");
                                Console.WriteLine();
                                Surgeon sergeant = new Surgeon(tIDEN, tLSTN, tFSTN, tSPEC, tOPER);
                                sergeant.Detail();
                                Console.Write("Is this correct? (Y/N):");
                                Char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    b3 = true;
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else
                                    {
                                        c0 = 'N';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            if (c0 == 'Y')
                            {
                                
                                CATG[a] = "SGT";
                                IDEN[a] = tIDEN;
                                LSTN[a] = tLSTN;
                                FSTN[a] = tFSTN;
                                SPEC[a] = tSPEC;
                                OPER[a] = tOPER;
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("What would you like to do?");
                                Console.WriteLine("1 - Create Another Surgeon");
                                Console.WriteLine("2 - Create Another Employee");
                                Console.WriteLine("3 - Return to Main Menu");
                                int.TryParse(Console.ReadLine(), out i0);
                                if (i0 > 0 && i0 < 4)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            if (i0 == 2)
                            {
                                b2 = true;
                            }
                            else if (i0 == 3)
                            {
                                b1 = true;
                                b2 = true;
                            }
                        }
                        break;
                    case 10:
                        b2 = false;
                        b3 = false;
                        while (b2 == false)
                        {
                            Reset();
                            while (b3 == false)
                            {
                                b3 = true;
                                for (int index = 0; index < IDEN.Length; index++)
                                {
                                    if (tIDEN == IDEN[index])
                                    {
                                        b3 = false;
                                    }
                                }
                                if (b3 == false)
                                {
                                    tIDEN++;
                                }
                            }
                            Console.WriteLine("[1/4] Please Enter the Last Name: ");
                            tLSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[2/4] Please Enter the First Name: ");
                            tFSTN = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("[3/4] Please Enter the Café Type: ");
                            tCFET = Console.ReadLine();
                            Console.WriteLine();
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("[4/4] How many Customer(s)?");
                                int.TryParse(Console.ReadLine(), out tCSTM);
                                if (tCSTM >= 0)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("SUMMARY");
                                Console.WriteLine();
                                Waiter waiter = new Waiter(tIDEN, tLSTN, tFSTN, tCFET, tCSTM);
                                waiter.Detail();
                                Console.Write("Is this correct? (Y/N):");
                                Char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    b3 = true;
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else
                                    {
                                        c0 = 'N';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            if (c0 == 'Y')
                            {
                                
                                CATG[a] = "WTR";
                                IDEN[a] = tIDEN;
                                LSTN[a] = tLSTN;
                                FSTN[a] = tFSTN;
                                CFET[a] = tCFET;
                                CSTM[a] = tCSTM;
                            }
                            b3 = false;
                            while (b3 == false)
                            {
                                Console.WriteLine("What would you like to do?");
                                Console.WriteLine("1 - Create Another Waiter");
                                Console.WriteLine("2 - Create Another Employee");
                                Console.WriteLine("3 - Return to Main Menu");
                                int.TryParse(Console.ReadLine(), out i0);
                                if (i0 > 0 && i0 < 4)
                                {
                                    b3 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            if (i0 == 2)
                            {
                                b2 = true;
                            }
                            else if (i0 == 3)
                            {
                                b1 = true;
                                b2 = true;
                            }
                        }
                        break;
                }
            }
        }
        public void DropEmployee()
        {
            b1 = false;
            b2 = false;
            while (b1 == false)
            {
                while (b2 == false)
                {
                    Console.WriteLine();
                    v.Frame("==");
                    Console.WriteLine("MAIN >> DROP");
                    v.Frame("==");
                    int count = 0;
                    Console.WriteLine("Which of the following Employee(s) would you like to drop?");
                    for (int index = 0; IDEN[index] != -1; index++)
                    {
                        Console.WriteLine((index + 1) + " - " + LSTN[index] + " " + FSTN[index]);
                        count = index;
                    }
                    count++;
                    Console.WriteLine("0 - RETURN TO MAIN MENU");
                    int.TryParse(Console.ReadLine(), out i0);
                    if (i0 > -1 && i0 < (count + 1))
                    {
                        b2 = true;
                    }
                    else
                    {
                        Console.WriteLine(Error(0));
                    }
                }
                if (i0 == 0)
                {
                    b1 = true;
                }
                else
                {
                    b2 = false;
                    i0--;
                    while (b2 == false)
                    {
                        Console.WriteLine("Are you sure you want to drop " + FSTN[i0] + " " + LSTN[i0]);
                        Console.Write("(Y/N) :");
                        Char.TryParse(Console.ReadLine(), out c0);
                        if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                        {
                            b2 = true;
                            if (c0 == 'y')
                            {
                                c0 = 'Y';
                            }
                            else if (c0 == 'n')
                            {
                                c0 = 'N';
                            }
                            if (c0 == 'N')
                            {
                                b1 = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine(Error(1));
                        }
                    }
                }
                if (c0 == 'Y')
                {
                    string a = CATG[i0];
                    IDEN[i0] = -1;
                    CATG[i0] = "";
                    LSTN[i0] = "";
                    FSTN[i0] = "";
                    DEPT[i0] = "";
                    CFET[i0] = "";
                    SPEC[i0] = "";
                    PATI[i0] = 0;
                    FOOD[i0] = 0;
                    SWEP[i0] = '\0';
                    ANSW[i0] = '\0';
                    OPER[i0] = '\0';
                    CSTM[i0] = 0;
                    for (int index = i0; index < IDEN.Length; index++)
                    {
                        IDEN[i0] = IDEN[i0 + 1];
                        CATG[i0] = CATG[i0 + 1];
                        LSTN[i0] = LSTN[i0 + 1];
                        FSTN[i0] = FSTN[i0 + 1];
                        DEPT[i0] = DEPT[i0 + 1];
                        CFET[i0] = CFET[i0 + 1];
                        SPEC[i0] = SPEC[i0 + 1];
                        PATI[i0] = PATI[i0 + 1];
                        FOOD[i0] = FOOD[i0 + 1];
                        SWEP[i0] = SWEP[i0 + 1];
                        ANSW[i0] = ANSW[i0 + 1];
                        OPER[i0] = OPER[i0 + 1];
                        CSTM[i0] = CSTM[i0 + 1];
                    }
                    b2 = false;
                    while (b2 == false)
                    {
                        Console.WriteLine("Drop another Employee?");
                        Console.Write("(Y/N): ");
                        Char.TryParse(Console.ReadLine(), out c0);
                        if (c0 == 'y')
                        {
                            c0 = 'Y';
                        }
                        else if (c0 == 'n')
                        {
                            c0 = 'N';
                        }
                        if (c0 == 'Y' || c0 == 'N')
                        {
                            b2 = true;
                        }
                        else
                        {
                            Console.WriteLine(Error(1));
                        }
                    }
                    if (c0 == 'N')
                    {
                        b1 = true;
                    }
                }
            }
        }
        public void ModifyEmployee()
        {
            b1 = false;
            b2 = false;
            while (b1 == false)
            {
                while (b2 == false)
                {
                    Console.WriteLine();
                    v.Frame("==");
                    Console.WriteLine("MAIN >> MODIFY");
                    v.Frame("==");
                    int count = 0;
                    Console.WriteLine("Which of the following Employee(s) would you like to modify?");
                    for (int index = 0; IDEN[index] != -1; index++)
                    {
                        Console.WriteLine((index + 1) + " - " + LSTN[index] + " " + FSTN[index]);
                        count = index;
                    }
                    count++;
                    Console.WriteLine("0 - RETURN TO MAIN MENU");
                    int.TryParse(Console.ReadLine(), out i0);
                    if (i0 > -1 && i0 < count)
                    {
                        b2 = true;
                    }
                    else
                    {
                        Console.WriteLine(Error(0));
                    }
                }
                if (i0 == 0)
                {
                    b1 = true;
                }
                else
                {
                    b2 = false;
                    i0--;
                    while (b2 == false)
                    {
                        Console.WriteLine("Are you sure you want to modify " + FSTN[i0] + " " + LSTN[i0]);
                        Console.Write("(Y/N) :");
                        Char.TryParse(Console.ReadLine(), out c0);
                        if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                        {
                            b2 = true;
                            if (c0 == 'y')
                            {
                                c0 = 'Y';
                            }
                            else if (c0 == 'n')
                            {
                                c0 = 'N';
                            }
                        }
                        else
                        {
                            Console.WriteLine(Error(1));
                        }
                    }
                }
                if (c0 == 'Y')
                {
                    b2 = false;
                    Reset();
                    while (b2 == false)
                    {
                        Console.WriteLine("Please select a Position");
                        Console.WriteLine("1 - Administrator");
                        Console.WriteLine("2 - Café Manager");
                        Console.WriteLine("3 - Chef");
                        Console.WriteLine("4 - Doctor");
                        Console.WriteLine("5 - Hospital Employee");
                        Console.WriteLine("6 - Janitor");
                        Console.WriteLine("7 - Nurse");
                        Console.WriteLine("8 - Receptionist");
                        Console.WriteLine("9 - Surgeon");
                        Console.WriteLine("10 - Waiter");
                        int.TryParse(Console.ReadLine(), out i1);
                        if (i1 > 0 && i1 < 11)
                        {
                            b2 = true;
                        }
                        else
                        {
                            Console.WriteLine(Error(0));
                        }
                    }
                    switch (i1)
                    {
                        case 1:
                            tCATG = "ADM";
                            Console.Write("Please enter the Department : ");
                            tDEPT = Console.ReadLine();
                            Administrator ad = new Administrator(IDEN[i0], LSTN[i0], FSTN[i0], tDEPT);
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Is this setting ok (Y/N) : ");
                                ad.Detail();
                                char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else if (c0 == 'n')
                                    {
                                        c0 = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            break;
                        case 2:
                            tCATG = "CFM";
                            Console.Write("Please enter the Café Type : ");
                            tCFET = Console.ReadLine();
                            CafeManager cm = new CafeManager(IDEN[i0], LSTN[i0], FSTN[i0], tCFET);
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Is this setting ok (Y/N) : ");
                                cm.Detail();
                                char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else if (c0 == 'n')
                                    {
                                        c0 = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            break;
                        case 3:
                            tCATG = "CHF";
                            Console.Write("Please enter the Café Type : ");
                            tCFET = Console.ReadLine();
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("How many Food(s) Prepared : ");
                                int.TryParse(Console.ReadLine(), out tFOOD);
                                if (tFOOD > -1)
                                {
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            Chef ch = new Chef(IDEN[i0], LSTN[i0], FSTN[i0], tCFET, tFOOD);
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Is this setting ok (Y/N) : ");
                                ch.Detail();
                                char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else if (c0 == 'n')
                                    {
                                        c0 = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            break;
                        case 4:
                            tCATG = "DOC";
                            Console.Write("Please enter the Specialty : ");
                            tSPEC = Console.ReadLine();
                            Doctor dr = new Doctor(IDEN[i0], LSTN[i0], FSTN[i0], tSPEC);
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Is this setting ok (Y/N) : ");
                                dr.Detail();
                                char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else if (c0 == 'n')
                                    {
                                        c0 = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            break;
                        case 5:
                            tCATG = "HOS";
                            HospitalEmployee he = new HospitalEmployee(IDEN[i0], LSTN[i0], FSTN[i0]);
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Is this setting ok (Y/N) : ");
                                he.Detail();
                                char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else if (c0 == 'n')
                                    {
                                        c0 = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            break;
                        case 6:
                            tCATG = "JAN";
                            Console.Write("Please enter the Department : ");
                            tDEPT = Console.ReadLine();
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Does Sweeping (Y/N) : ");
                                char.TryParse(Console.ReadLine(), out tSWEP);
                                if (tSWEP == 'Y' || tSWEP == 'y' || tSWEP == 'N' || tSWEP == 'n')
                                {
                                    if (tSWEP == 'y')
                                    {
                                        tSWEP = 'Y';
                                    }
                                    else if (tSWEP == 'n')
                                    {
                                        tSWEP = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            Janitor jn = new Janitor(IDEN[i0], LSTN[i0], FSTN[i0], tDEPT, tSWEP);
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Is this setting ok (Y/N) : ");
                                jn.Detail();
                                char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else if (c0 == 'n')
                                    {
                                        c0 = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            break;
                        case 7:
                            tCATG = "NRS";
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("How many Patient(s) : ");
                                int.TryParse(Console.ReadLine(), out tPATI);
                                if (tPATI > -1)
                                {
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            Nurse nr = new Nurse(IDEN[i0], LSTN[i0], FSTN[i0], tPATI);
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Is this setting ok (Y/N) : ");
                                nr.Detail();
                                char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else if (c0 == 'n')
                                    {
                                        c0 = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            break;
                        case 8:
                            tCATG = "REC";
                            Console.Write("Please enter the Department : ");
                            tDEPT = Console.ReadLine();
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Does Answering (Y/N) : ");
                                char.TryParse(Console.ReadLine(), out tANSW);
                                if (tANSW == 'Y' || tANSW == 'y' || tANSW == 'N' || tANSW == 'n')
                                {
                                    if (tANSW == 'y')
                                    {
                                        tANSW = 'Y';
                                    }
                                    else if (tANSW == 'n')
                                    {
                                        tANSW = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            Receptionist rc = new Receptionist(IDEN[i0], LSTN[i0], FSTN[i0], tDEPT, tANSW);
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Is this setting ok (Y/N) : ");
                                rc.Detail();
                                char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else if (c0 == 'n')
                                    {
                                        c0 = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            break;
                        case 9:
                            tCATG = "SGT";
                            Console.Write("Please enter the Specialty : ");
                            tSPEC = Console.ReadLine();
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Does Operating (Y/N) : ");
                                char.TryParse(Console.ReadLine(), out tOPER);
                                if (tOPER == 'Y' || tOPER == 'y' || tOPER == 'N' || tOPER == 'n')
                                {
                                    if (tOPER == 'y')
                                    {
                                        tOPER = 'Y';
                                    }
                                    else if (tOPER == 'n')
                                    {
                                        tOPER = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                                Surgeon sg = new Surgeon(IDEN[i0], LSTN[i0], FSTN[i0], tSPEC, tOPER);
                                b2 = false;
                                while (b2 == false)
                                {
                                    Console.Write("Is this setting ok (Y/N) : ");
                                    sg.Detail();
                                    char.TryParse(Console.ReadLine(), out c0);
                                    if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                    {
                                        if (c0 == 'y')
                                        {
                                            c0 = 'Y';
                                        }
                                        else if (c0 == 'n')
                                        {
                                            c0 = 'N';
                                        }
                                        b2 = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine(Error(1));
                                    }
                                }
                            }
                            break;
                        case 10:
                            tCATG = "WTR";
                            Console.Write("Please enter the Café Type : ");
                            tCFET = Console.ReadLine();
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("How many Customer(s) : ");
                                int.TryParse(Console.ReadLine(), out tCSTM);
                                if (tCSTM > -1)
                                {
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(0));
                                }
                            }
                            Waiter wt = new Waiter(IDEN[i0], LSTN[i0], FSTN[i0], tCFET, tCSTM);
                            b2 = false;
                            while (b2 == false)
                            {
                                Console.Write("Is this setting ok (Y/N) : ");
                                wt.Detail();
                                char.TryParse(Console.ReadLine(), out c0);
                                if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                                {
                                    if (c0 == 'y')
                                    {
                                        c0 = 'Y';
                                    }
                                    else if (c0 == 'n')
                                    {
                                        c0 = 'N';
                                    }
                                    b2 = true;
                                }
                                else
                                {
                                    Console.WriteLine(Error(1));
                                }
                            }
                            break;
                    }
                    if (c0 == 'Y')
                    {
                        CATG[i0] = tCATG;
                        DEPT[i0] = tDEPT;
                        SWEP[i0] = tSWEP;
                        ANSW[i0] = tANSW;
                        CFET[i0] = tCFET;
                        FOOD[i0] = tFOOD;
                        CSTM[i0] = tCSTM;
                        SPEC[i0] = tSPEC;
                        OPER[i0] = tOPER;
                        PATI[i0] = tPATI;
                        Reset();
                    }
                    b2 = false;
                    while (b2 == false)
                    {
                        Console.Write("Change another Employee (Y/N) : ");
                        char.TryParse(Console.ReadLine(), out c0);
                        if (c0 == 'Y' || c0 == 'y' || c0 == 'N' || c0 == 'n')
                        {
                            if (c0 == 'y')
                            {
                                c0 = 'Y';
                            }
                            else if (c0 == 'n')
                            {
                                c0 = 'N';
                            }
                            b2 = true;
                        }
                        else
                        {
                            Console.WriteLine(Error(1));
                        }
                    }
                    if (c0 == 'N')
                    {
                        b1 = true;
                    }
                }
            }
        }
        public void SaveEmployees()
        {
            File.WriteAllText(fileLocation, String.Empty);
            int index = 0;
            int index0 = 0;
            while (IDEN[index0] != -1)
            {
                index0++;
            }
            string[] lines = new string[index0];
            while (LSTN[index] != "")
            {
                if (CATG[index] == "ADM")
                {
                    Administrator adm = new Administrator(IDEN[index], LSTN[index], FSTN[index], DEPT[index]);
                    lines[index] = adm.ToString();
                }
                else if (CATG[index] == "CFM")
                {
                    CafeManager cfm = new CafeManager(IDEN[index], LSTN[index], FSTN[index], CFET[index]);
                    lines[index] = cfm.ToString();
                }
                else if (CATG[index] == "CHF")
                {
                    Chef chf = new Chef(IDEN[index], LSTN[index], FSTN[index], CFET[index], FOOD[index]);
                    lines[index] = chf.ToString();
                }
                else if (CATG[index] == "DOC")
                {
                    Doctor doc = new Doctor(IDEN[index], LSTN[index], FSTN[index], SPEC[index]);
                    lines[index] = doc.ToString();
                }
                else if (CATG[index] == "HOS")
                {
                    HospitalEmployee hos = new HospitalEmployee(IDEN[index], LSTN[index], FSTN[index]);
                    lines[index] = hos.ToString();
                }
                else if (CATG[index] == "JAN")
                {
                    Janitor jan = new Janitor(IDEN[index], LSTN[index], FSTN[index], DEPT[index], SWEP[index]);
                    lines[index] = jan.ToString();
                }
                else if (CATG[index] == "NRS")
                {
                    Nurse nrs = new Nurse(IDEN[index], LSTN[index], FSTN[index], PATI[index]);
                    lines[index] = nrs.ToString();
                }
                else if (CATG[index] == "REC")
                {
                    Receptionist rec = new Receptionist(IDEN[index], LSTN[index], FSTN[index], DEPT[index], ANSW[index]);
                    lines[index] = rec.ToString();
                }
                else if (CATG[index] == "SGT")
                {
                    Surgeon sgt = new Surgeon(IDEN[index], LSTN[index], FSTN[index], SPEC[index], OPER[index]);
                    lines[index] = sgt.ToString();
                }
                else if (CATG[index] == "WTR")
                {
                    Waiter wtr = new Waiter(IDEN[index], LSTN[index], FSTN[index], CFET[index], CSTM[index]);
                    lines[index] = wtr.ToString();
                }
                index++;
            }
            for (int a = 0; a < index; a++)
            {
                File.WriteAllLines(fileLocation, lines);
            }
        }
        public void ViewEmployees()
        {
            bool numbers = false;
            int size = 0;
            while (IDEN[size] != -1)
            {
                size++;
            }
            int adm = 0;
            int cfm = 0;
            int chf = 0;
            int doc = 0;
            int hos = 0;
            int jan = 0;
            int nrs = 0;
            int rec = 0;
            int sgt = 0;
            int wtr = 0;
            char[] aANSW = new char[size];
            string[] aCFET = new string[size];
            string[] aCATG = new string[size];
            int[] aCSTM = new int[size];
            string[] aDEPT = new string[size];
            string[] aFSTN = new string[size];
            int[] aFOOD = new int[size];
            int[] aIDEN = new int[size];
            string[] aLSTN = new string[size];
            char[] aOPER = new char[size];
            int[] aPATI = new int[size];
            string[] aSPEC = new string[size];
            char[] aSWEP = new char[size];
            string[] aNAME = new string[size];
            for (int a = 0; IDEN[a] != -1; a++)
            {
                aNAME[a] = LSTN[a] + " " + FSTN[a] + " " + IDEN[a] + " " + CATG[a];
                if (CATG[a] == "ADM" || CATG[a] == "JAN" || CATG[a] == "REC")
                {
                    aNAME[a] += (" " + DEPT[a]);
                    if (CATG[a] == "JAN")
                    {
                        aNAME[a] += (" " + SWEP[a]);
                    }
                    else if (CATG[a] == "REC")
                    {
                        aNAME[a] += (" " + ANSW[a]);
                    }
                }
                else if (CATG[a] == "CFM" || CATG[a] == "CHF" || CATG[a] == "WTR")
                {
                    aNAME[a] += (" " + CFET[a]);
                    if (CATG[a] == "CHF")
                    {
                        aNAME[a] += (" " + FOOD[a]);
                    }
                    else if (CATG[a] == "WTR")
                    {
                        aNAME[a] += (" " + CSTM[a]);
                    }
                }
                else if (CATG[a] == "DOC" || CATG[a] == "SGT")
                {
                    aNAME[a] += (" " + SPEC[a]);
                    if (CATG[a] == "SGT")
                    {
                        aNAME[a] += (" " + OPER[a]);
                    }
                }
                else if (CATG[a] == "NRS")
                {
                    aNAME[a] += (" " + PATI[a]);
                }
            }
            Array.Sort(aNAME);
            int a0 = 0;
            foreach (var lines in aNAME)
            {
                if (lines.Contains("ADM"))
                {
                    string[] entries = lines.Split(' ');
                    aLSTN[a0] = entries[0];
                    aFSTN[a0] = entries[1];
                    aIDEN[a0] = int.Parse(entries[2]);
                    aCATG[a0] = entries[3];
                    aDEPT[a0] = entries[4];
                }
                else if (aNAME[a0].Contains("CFM"))
                {
                    string[] entries = lines.Split(' ');
                    aLSTN[a0] = entries[0];
                    aFSTN[a0] = entries[1];
                    aIDEN[a0] = int.Parse(entries[2]);
                    aCATG[a0] = entries[3];
                    aCFET[a0] = entries[4];
                }
                else if (aNAME[a0].Contains("CHF"))
                {
                    string[] entries = lines.Split(' ');
                    aLSTN[a0] = entries[0];
                    aFSTN[a0] = entries[1];
                    aIDEN[a0] = int.Parse(entries[2]);
                    aCATG[a0] = entries[3];
                    aCFET[a0] = entries[4];
                    aFOOD[a0] = int.Parse(entries[5]);
                }
                else if (aNAME[a0].Contains("DOC"))
                {
                    string[] entries = lines.Split(' ');
                    aLSTN[a0] = entries[0];
                    aFSTN[a0] = entries[1];
                    aIDEN[a0] = int.Parse(entries[2]);
                    aCATG[a0] = entries[3];
                    aSPEC[a0] = entries[4];
                }
                else if (aNAME[a0].Contains("HOS"))
                {
                    string[] entries = lines.Split(' ');
                    aLSTN[a0] = entries[0];
                    aFSTN[a0] = entries[1];
                    aIDEN[a0] = int.Parse(entries[2]);
                    aCATG[a0] = entries[3];
                }
                else if (aNAME[a0].Contains("JAN"))
                {
                    string[] entries = lines.Split(' ');
                    aLSTN[a0] = entries[0];
                    aFSTN[a0] = entries[1];
                    aIDEN[a0] = int.Parse(entries[2]);
                    aCATG[a0] = entries[3];
                    aDEPT[a0] = entries[4];
                    aSWEP[a0] = char.Parse(entries[5]);
                }
                else if (aNAME[a0].Contains("NRS"))
                {
                    string[] entries = lines.Split(' ');
                    aLSTN[a0] = entries[0];
                    aFSTN[a0] = entries[1];
                    aIDEN[a0] = int.Parse(entries[2]);
                    aCATG[a0] = entries[3];
                    aPATI[a0] = int.Parse(entries[4]);
                }
                else if (aNAME[a0].Contains("REC"))
                {
                    string[] entries = lines.Split(' ');
                    aLSTN[a0] = entries[0];
                    aFSTN[a0] = entries[1];
                    aIDEN[a0] = int.Parse(entries[2]);
                    aCATG[a0] = entries[3];
                    aDEPT[a0] = entries[4];
                    aANSW[a0] = char.Parse(entries[5]);
                }
                else if (aNAME[a0].Contains("SGT"))
                {
                    string[] entries = lines.Split(' ');
                    aLSTN[a0] = entries[0];
                    aFSTN[a0] = entries[1];
                    aIDEN[a0] = int.Parse(entries[2]);
                    aCATG[a0] = entries[3];
                    aSPEC[a0] = entries[4];
                    aOPER[a0] = char.Parse(entries[5]);
                }
                else if (aNAME[a0].Contains("WTR"))
                {
                    string[] entries = lines.Split(' ');
                    aLSTN[a0] = entries[0];
                    aFSTN[a0] = entries[1];
                    aIDEN[a0] = int.Parse(entries[2]);
                    aCATG[a0] = entries[3];
                    aCFET[a0] = entries[4];
                    aCSTM[a0] = int.Parse(entries[5]);
                }
                a0++;
            }
            for (int a = 0; a < size; a++)
            {
                if (CATG[a] == "ADM")
                {
                    adm++;
                }
                else if (CATG[a] == "CFM")
                {
                    cfm++;
                }
                else if (CATG[a] == "CHF")
                {
                    chf++;
                }
                else if (CATG[a] == "DOC")
                {
                    doc++;
                }
                else if (CATG[a] == "HOS")
                {
                    hos++;
                }
                else if (CATG[a] == "JAN")
                {
                    jan++;
                }
                else if (CATG[a] == "NRS")
                {
                    nrs++;
                }
                else if (CATG[a] == "REC")
                {
                    rec++;
                }
                else if (CATG[a] == "SGT")
                {
                    sgt++;
                }
                else if (CATG[a] == "WTR")
                {
                    wtr++;
                }
            }
            if (adm > 0)
            {
                numbers = true;
                v.Frame("==");
                Console.WriteLine("{0, 57}", "ADMINISTRATORS");
                v.Frame("==");
                /*if (adm == 1)
                {
                    Console.WriteLine("There is currently 1 Administrator");
                }
                else
                {
                    Console.WriteLine("There are currently " + adm + " Administrators");
                }*/
                Console.WriteLine();
                Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D}", "#", "LAST NAME", "FIRST NAME", "IDENTITY", "DEPARTMENT");
                v.Frame("--");
                int b = 1;
                for (int a = 0; a < size; a++)
                {
                    if (aCATG[a] == "ADM")
                    {
                        Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D}", b, aLSTN[a], aFSTN[a], aIDEN[a], aDEPT[a]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            if (cfm > 0)
            {
                numbers = true;
                v.Frame("==");
                Console.WriteLine("{0, 56}", "CAFE MANAGERS");
                v.Frame("==");
                /*if (cfm == 1)
                {
                    Console.WriteLine("There is currently 1 Café Manager");
                }
                else
                {
                    Console.WriteLine("There are currently " + cfm + " Café Managers");
                }*/
                Console.WriteLine();
                Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D}", "#", "LAST NAME", "FIRST NAME", "IDENTITY", "CAFE TYPE");
                v.Frame("--");
                int b = 1;
                for (int a = 0; a < size; a++)
                {
                    if (aCATG[a] == "CFM")
                    {
                        Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D}", b, aLSTN[a], aFSTN[a], aIDEN[a], aCFET[a]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            if (chf > 0)
            {
                numbers = true;
                v.Frame("==");
                Console.WriteLine("{0, 52}", "CHEF");
                v.Frame("==");
                /*if (chf == 1)
                {
                    Console.WriteLine("There is currently 1 Chef");
                }
                else
                {
                    Console.WriteLine("There are currently " + chf + " Chefs");
                }*/
                Console.WriteLine();
                Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D} {5, 20:D}", "#", "LAST NAME", "FIRST NAME", "IDENTITY", "CAFE TYPE", "FOOD(S) PREPARED");
                v.Frame("--");
                int b = 1;
                for (int a = 0; a < size; a++)
                {
                    if (aCATG[a] == "CHF")
                    {
                        Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D} {5, 20:D}", b, aLSTN[a], aFSTN[a], aIDEN[a], aCFET[a], aFOOD[a]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            if (doc > 0)
            {
                numbers = true;
                v.Frame("==");
                Console.WriteLine("{0, 53}", "DOCTORS");
                v.Frame("==");
                /*if (doc == 1)
                {
                    Console.WriteLine("There is currently 1 Doctor");
                }
                else
                {
                    Console.WriteLine("There are currently " + doc + " Doctors");
                }*/
                Console.WriteLine();
                Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D}", "#", "LAST NAME", "FIRST NAME", "IDENTITY", "SPECIALTY");
                v.Frame("--");
                int b = 1;
                for (int a = 0; a < size; a++)
                {
                    if (aCATG[a] == "DOC")
                    {
                        Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D}", b, aLSTN[a], aFSTN[a], aIDEN[a], aSPEC[a]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            if (hos > 0)
            {
                numbers = true;
                v.Frame("==");
                Console.WriteLine("{0, 59}", "HOSPITAL EMPLOYEES");
                v.Frame("==");
                /*if (hos == 1)
                {
                    Console.WriteLine("There is currently 1 Hospital Employee");
                }
                else
                {
                    Console.WriteLine("There are currently " + hos + " Hospital Employees");
                }*/
                Console.WriteLine();
                Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D}", "#", "LAST NAME", "FIRST NAME", "IDENTITY");
                v.Frame("--");
                int b = 1;
                for (int a = 0; a < size; a++)
                {
                    if (aCATG[a] == "HOS")
                    {
                        Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D}", b, aLSTN[a], aFSTN[a], aIDEN[a]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            if (jan > 0)
            {
                numbers = true;
                v.Frame("==");
                Console.WriteLine("{0, 54}", "JANITORS");
                v.Frame("==");
                /*if (jan == 1)
                {
                    Console.WriteLine("There is currently 1 Janitor");
                }
                else
                {
                    Console.WriteLine("There are currently " + jan + " Janitors");
                }*/
                Console.WriteLine();
                Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D} {5, 20:D}", "#", "LAST NAME", "FIRST NAME", "IDENTITY", "DEPARTMENT", "SWEEPING");
                v.Frame("--");
                int b = 1;
                for (int a = 0; a < size; a++)
                {
                    if (aCATG[a] == "JAN")
                    {
                        Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D} {5, 20:D}", b, aLSTN[a], aFSTN[a], aIDEN[a], aDEPT[a], aSWEP[a]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            if (nrs > 0)
            {
                numbers = true;
                v.Frame("==");
                Console.WriteLine("{0, 52}", "NURSE");
                v.Frame("==");
                /*if (nrs == 1)
                {
                    Console.WriteLine("There is currently 1 Nurse");
                }
                else
                {
                    Console.WriteLine("There are currently " + nrs + " Nurses");
                }*/
                Console.WriteLine();
                Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D}", "#", "LAST NAME", "FIRST NAME", "IDENTITY", "PATIENT(S)");
                v.Frame("--");
                int b = 1;
                for (int a = 0; a < size; a++)
                {
                    if (aCATG[a] == "NRS")
                    {
                        Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D}", b, aLSTN[a], aFSTN[a], aIDEN[a], aPATI[a]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            if (rec > 0)
            {
                numbers = true;
                v.Frame("==");
                Console.WriteLine("{0, 56}", "RECEPTIONISTS");
                v.Frame("==");
                /*if (rec == 1)
                {
                    Console.WriteLine("There is currently 1 Receptionist");
                }
                else
                {
                    Console.WriteLine("There are currently " + rec + " Receptionists");
                }*/
                Console.WriteLine();
                Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D} {5, 20:D}", "#", "LAST NAME", "FIRST NAME", "IDENTITY", "DEPARTMENT", "ANSWERING");
                v.Frame("--");
                int b = 1;
                for (int a = 0; a < size; a++)
                {
                    if (aCATG[a] == "REC")
                    {
                        Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D} {5, 20:D}", b, aLSTN[a], aFSTN[a], aIDEN[a], aDEPT[a], aANSW[a]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            if (sgt > 0)
            {
                numbers = true;
                v.Frame("==");
                Console.WriteLine("{0, 54}", "SURGEONS");
                v.Frame("==");
                /*if (sgt == 1)
                {
                    Console.WriteLine("There is currently 1 Surgeon");
                }
                else
                {
                    Console.WriteLine("There are currently " + sgt + " Surgeons");
                }*/
                Console.WriteLine();
                Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D} {5, 20:D}", "#", "LAST NAME", "FIRST NAME", "IDENTITY", "SPECIALTY", "OPERATING");
                v.Frame("--");
                int b = 1;
                for (int a = 0; a < size; a++)
                {
                    if (aCATG[a] == "SGT")
                    {
                        Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D} {5, 20:D}", b, aLSTN[a], aFSTN[a], aIDEN[a], aSPEC[a], aOPER[a]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            if (wtr > 0)
            {
                numbers = true;
                v.Frame("==");
                Console.WriteLine("{0, 53}", "WAITER");
                v.Frame("==");
                /*if (wtr == 1)
                {
                    Console.WriteLine("There is currently 1 Waiter");
                }
                else
                {
                    Console.WriteLine("There are currently " + wtr + " Waiters");
                }*/
                Console.WriteLine();
                Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D} {5, 20:D}", "#", "LAST NAME", "FIRST NAME", "IDENTITY", "CAFE TYPE", "CUSTOMER(S)");
                v.Frame("--");
                int b = 1;
                for (int a = 0; a < size; a++)
                {
                    if (aCATG[a] == "WTR")
                    {
                        Console.WriteLine("{0, -7:D} {1, -20:D} {2, -20:D} {3, 8:D} {4, 20:D} {5, 20:D}", b, aLSTN[a], aFSTN[a], aIDEN[a], aCFET[a], aCSTM[a]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            if (numbers == false)
            {
                Console.WriteLine("There are currently no employees . . . ");
            }
        }
        public string Error(int a)
        {
            string b = "";
            if (a == 0)
            {
                b = "ERROR: Please enter the appropriate number";
            }
            else if (a == 1)
            {
                b = "ERROR: Please enter Y or N";
            }
            return b;
        }
    }
}