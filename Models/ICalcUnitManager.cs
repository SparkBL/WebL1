namespace WebL_1.Models
{
    public interface ICalcUnitManager
    {
        public ICalcUnit cur { get; }
        public ICalcUnit Rebase();
    }
}