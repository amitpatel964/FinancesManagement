using System;
using System.Collections.Generic;

namespace FinancesManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // This section of code is mainly for testing purposes

            Console.WriteLine("Select/Add Household");

            Household houseOne = new Household();

            while (true)
            {
                Console.WriteLine("Main Menu: Please pick one of the following options");
                Console.WriteLine("1. Select/Add User");
                Console.WriteLine("2. View/Edit House Income Sources");
                Console.WriteLine("3. View/Edit House Expenses");
                Console.WriteLine("4. Exit");
                Console.Write("Input: ");

                string input = Console.ReadLine();

                if (input.Equals("1"))
                {
                    if (houseOne.Members.Count == 0)
                    {
                        Console.WriteLine("No users in current household. Please enter a name: ");
                        string newName = Console.ReadLine();
                        User newUser = new User(newName);
                        houseOne.addMember(newUser);
                    }
                }
                else if (input.Equals("2"))
                {

                }
                else if (input.Equals("3"))
                {

                }
                else if (input.Equals("4"))
                {
                    break;
                }
            }
        }
    }

    // The User class keeps track of a person's name, which banks they have an account at and how much cash they have on hand.
    // More variables will be added as the scope of the program increases.
    public class User
    {
        private string name;
        private List<Bank> userBanks;
        private int cashOnHand;
        private List<Income> incomeSourcesForUser;
        private List<Expense> expensesForUser;
        private int totalAmountOfMoney;
        private int netIncome;

        public User (string name)
        {
            this.Name = name;
            this.userBanks = new List<Bank>();
            this.incomeSourcesForUser = new List<Income>();
            this.expensesForUser = new List<Expense>();
        }

        public string Name { get => name; set => name = value; }
        public int CashOnHand { get => cashOnHand; set => cashOnHand = value; }
        public List<Bank> UserBanks { get => userBanks; set => userBanks = value; }
        public List<Income> IncomeSourcesForUser { get => incomeSourcesForUser; set => incomeSourcesForUser = value; }
        public List<Expense> ExpensesForUser { get => expensesForUser; set => expensesForUser = value; }
        public int TotalAmountOfMoney { get => totalAmountOfMoney; set => totalAmountOfMoney = value; }
        public int NetIncome { get => netIncome; set => netIncome = value; }

        public void addBank(Bank bankName)
        {
            this.UserBanks.Add(bankName);
        }
    }

    // The Bank class keeps track of a bank's name and four types of accounts they have.
    // More types of accounts will be added as needed.
    public class Bank
    {
        private string bankName;
        private int checkingAccountAmount;
        private int savingAccountAmount;
        private int moneyMarketAccountAmount;
        private int cdAccountAmount;

        public Bank (string bankName, int checkingAccountAmount, int savingAccountAmount)
        {
            this.BankName = bankName;
            this.CheckingAccountAmount = checkingAccountAmount;
            this.SavingAccountAmount = savingAccountAmount;
        }

        public string BankName { get => bankName; set => bankName = value; }
        public int CheckingAccountAmount { get => checkingAccountAmount; set => checkingAccountAmount = value; }
        public int SavingAccountAmount { get => savingAccountAmount; set => savingAccountAmount = value; }
        public int MoneyMarketAccountAmount { get => moneyMarketAccountAmount; set => moneyMarketAccountAmount = value; }
        public int CdAccountAmount { get => cdAccountAmount; set => cdAccountAmount = value; }
    }

    // The Household class keeps track of all of the members of a household. The members will be separate User classes.
    // This class also keeps track of the different expenses of the house. There are two ArrayLists to keep track of the expenses and the sources of income as well.
    // House income sources and expenses will automatically add income sources and expenses from the members of the household.
    // Expenses will mainly be monthly costs of the household and cars as well.
    // Please note that the household class can be used for houses, apartments, studios, condos, townhouses or any living space.
    public class Household
    {
        private List<User> members;
        private List<Income> sourcesOfIncomeOfHouse;
        private List<Expense> expensesOfHouse;

        public Household()
        {
            this.members = new List<User>();
            this.sourcesOfIncomeOfHouse = new List<Income>();
            this.expensesOfHouse = new List<Expense>();
        }

        public List<User> Members { get => members; set => members = value; }
        public List<Income> SourcesOfIncome { get => sourcesOfIncomeOfHouse; set => sourcesOfIncomeOfHouse = value; }
        public List<Expense> Expenses { get => expensesOfHouse; set => expensesOfHouse = value; }

        public void addMember(User newMember)
        {
            this.members.Add(newMember);
        }

        public void addSourceOfIncome(Income newSourceOfIncome)
        {
            this.sourcesOfIncomeOfHouse.Add(newSourceOfIncome);
        }

        public void addExpense(Expense newExpense)
        {
            this.expensesOfHouse.Add(newExpense);
        }
    }

    // The Income class keeps track of the name of a source of income and the amount of that source of income.
    public class Income
    {
        private string incomeName;
        private int incomeAmount;

        public Income(string incomeName, int incomeAmount)
        {
            this.IncomeName = incomeName;
            this.IncomeAmount = incomeAmount;
        }

        public string IncomeName { get => incomeName; set => incomeName = value; }
        public int IncomeAmount { get => incomeAmount; set => incomeAmount = value; }
    }

    // The Expense class keeps track of the name of an expense and the amount of that expense.
    public class Expense
    {
        private string expenseName;
        private int expenseAmount;

        public Expense(string expenseName, int expenseAmount)
        {
            this.ExpenseName = expenseName;
            this.ExpenseAmount = expenseAmount;
        }

        public string ExpenseName { get => expenseName; set => expenseName = value; }
        public int ExpenseAmount { get => expenseAmount; set => expenseAmount = value; }
    }
}
