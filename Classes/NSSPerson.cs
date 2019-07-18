namespace student_exercises
{
    public interface NSSPerson 
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string SlackHandle { get; set; }
        Cohort Cohort { get; set; }
    }
}