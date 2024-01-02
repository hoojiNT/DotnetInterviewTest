namespace InterviewTest;
public class Score
{
    public Score()
    {
        var random = new Random();
        Math = random.Next(0, 11);
        Physic = random.Next(0, 11);
        Chemistry = random.Next(0, 11);
    }

    public int Math { get; set; }
    public int Physic { get; set; }
    public int Chemistry { get; set; }

}

public class Student
{
    public string Name { get; set; }
    public Score Score { get; set; }

    public Student()
    {
        this.Score = new Score();
        this.Name = Faker.Name.First();
    }
    public double GetSumary()
    {
        return (Score.Math + Score.Physic + Score.Chemistry) / 3;
    }

    public void GetDetail()
    {
        Console.WriteLine("| {0,-25} | {1,-10} | {2,-10} | {3,-9} | {4,-9} |", Name, Score.Math, Score.Physic, Score.Chemistry, GetSumary());
    }

}