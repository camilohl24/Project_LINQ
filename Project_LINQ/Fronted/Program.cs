List<string> names = new List<string>
{
    "JULIAN", "Ana", "Andrés", "María", "Alberto", "Sofía", "juaquin","FabiaN","Esteban"
};
List<string> filteredNames = names
    .Where(L => L.EndsWith("n", StringComparison.InvariantCultureIgnoreCase))
    .OrderBy(L => L)
    .ToList();
foreach (string name in filteredNames)
{
    Console.WriteLine(name);
}