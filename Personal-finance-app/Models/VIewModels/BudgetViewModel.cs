namespace Personal_finance_app.Models.VIewModels
{
    public class BudgetViewModel
    {
        public List<Transaction>? Transatction { get; set; }
        public List<Transaction> Transactions { get; internal set; }
    }
}
