namespace PizzaSinglePageApp.Shared
{
    public class State
    {
        public Menu Menu { get; set; } = new Menu();
        public Basket Basket { get; set; } = new Basket();
        public UI Ui { get; set; } = new UI();
    }
}