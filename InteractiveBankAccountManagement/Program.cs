namespace InteractiveBankAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var cmArgs = command.Split();
                var cmType = cmArgs[0];
                switch (cmType)
                {
                    case "Create":
                        int id = int.Parse(cmArgs[1]);
                        if (accounts.ContainsKey(id))
                        {
                            Console.WriteLine("Account already exists");
                        }
                        else
                        {
                            BankAccount newAccount = new BankAccount();
                            newAccount.Id = id;
                            accounts.Add(id, newAccount);
                            Console.WriteLine($"Account {id} created");
                        }
                        break;
                    case "Deposit":
                        id = int.Parse(cmArgs[1]);
                        double amount = double.Parse(cmArgs[2]);
                        if (accounts.ContainsKey(id))
                        {
                            accounts[id].Deposit(amount);
                            Console.WriteLine($"Deposited {amount} to account {id}, balance: {accounts[id].Balance}");
                        }
                        else
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        break;
                    case "Withdraw":
                        id = int.Parse(cmArgs[1]);
                        amount = double.Parse(cmArgs[2]);
                        if (accounts.ContainsKey(id))
                        {
                            if (accounts[id].Balance >= amount)
                            {
                                accounts[id].Withdraw(amount);
                                Console.WriteLine($"Withdrawn {amount} from account {id}, balance: {accounts[id].Balance}");
                            }
                            else
                            {
                                Console.WriteLine($"Insufficient balance in account {id}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        break;
                    case "Print":
                        id = int.Parse(cmArgs[1]);
                        if (accounts.ContainsKey(id))
                        {
                            Console.WriteLine(accounts[id].ToString());
                        }
                        else
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
    }
}
