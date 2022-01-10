namespace Cloud.Logic.DomainModel
{
    public enum ServerSelectionStrategy
    {
       // PathBased, I think those two are more variations of a strategy than a strategy.
      //  IPBased,
        RoundRobin,
        Random
    }
}