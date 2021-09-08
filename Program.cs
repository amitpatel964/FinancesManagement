using System;
using System.Collections;

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
                break;
            }
        }
    }

    // The User class keeps track of a person's name, which banks they have an account at and how much cash they have on hand.
    // More variables will be added as the scope of the program increases.
    public class User
    {
        private string name;
        private ArrayList userBanks;
        private int cashOnHand;

        public User (string name, int cashOnHand)
        {
            this.Name = name;
            this.CashOnHand = cashOnHand;
        }

        public string Name { get => name; set => name = value; }
        public int CashOnHand { get => cashOnHand; set => cashOnHand = value; }
        public ArrayList UserBanks { get => userBanks; set => userBanks = value; }

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
    // Some expenses and sources of income may be separated to the User class to allow more customization, but I will see how this works for now.
    public class Household
    {
        private ArrayList members;
        private ArrayList sourcesOfIncome;
        private ArrayList expenses;

        public Household(ArrayList members, ArrayList sourcesOfIncome, ArrayList expenses)
        {
            this.Members = members;
            this.SourcesOfIncome = sourcesOfIncome;
            this.Expenses = expenses;
        }

        public Household()
        {

        }

        public ArrayList Members { get => members; set => members = value; }
        public ArrayList SourcesOfIncome { get => sourcesOfIncome; set => sourcesOfIncome = value; }
        public ArrayList Expenses { get => expenses; set => expenses = value; }

        public void addMember(User newMember)
        {
            this.members.Add(newMember);
        }

        public void addSourceOfIncome(Income newSourceOfIncome)
        {
            this.sourcesOfIncome.Add(newSourceOfIncome);
        }

        public void addExpense(Expense newExpense)
        {
            this.expenses.Add(newExpense);
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
