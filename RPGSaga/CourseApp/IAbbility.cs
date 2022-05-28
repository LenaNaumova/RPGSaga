namespace CourseApp
{
    public interface IAbbility
    {
        string Name { get; }

        int Damage { get; }

        int NumberOfUses { get; } // Количество использований

        int DurationOfAction { get; } // Продолжительность действия
    }
}
