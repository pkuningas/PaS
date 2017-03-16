namespace Logic
{
    public class PackageTypes : Archetypes<PackageType>
    {
        public static PackageTypes Instances { get; } = new PackageTypes();
    }
}
