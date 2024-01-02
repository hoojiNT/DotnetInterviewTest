using InterviewTest;

public class StudentList
{
    public Student[] Students { get; set; }


    public StudentList(int vol)
    {
        Students = new Student[vol];
        for (int i = 0; i < vol; i++)
        {
            Students[i] = new Student();
            // Console.WriteLine("| {0,-25} | {1,-10} | {2,-10} | {3,-9} |", Students[i].Name, Students[i].Score.Math, Students[i].Score.Physic, Students[i].Score.Chemistry);
        }
    }

    private Student[] SortByScore(Student[] students, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = students[leftIndex];
        while (i <= j)
        {
            while (students[i].GetSumary() < pivot.GetSumary())
            {
                i++;
            }

            while (students[j].GetSumary() > pivot.GetSumary())
            {
                j--;
            }

            if (i <= j)
            {
                (students[j], students[i]) = (students[i], students[j]);
                i++;
                j--;
            }
        }

        if (leftIndex < j)
            SortByScore(students, leftIndex, j);
        if (i < rightIndex)
            SortByScore(students, i, rightIndex);
        return students;
    }
    public static void SortByName(Student[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (string.Compare(arr[j].Name, arr[minIndex].Name, StringComparison.Ordinal) < 0 && (arr[j].GetSumary() == arr[minIndex].GetSumary()))
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                (arr[minIndex], arr[i]) = (arr[i], arr[minIndex]);
            }
        }
    }

    public Student Search(int target)
    {
        int left = 0;
        int right = Students.Length - 1;
        Student? result = null;
        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (Students[mid].GetSumary() == target)
            {
                result = Students[mid];
                break;
            }
            else if (Students[mid].GetSumary() < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        if (result != null)
        {
            System.Console.WriteLine("==studentWithSumaryEqual8==");
            result.GetDetail();
            return result;
        }
        else
        {
            throw new Exception("Not Found!");
        }
    }

    public void Sort()
    {
        var sortedStudents = SortByScore(Students, 0, Students.Length - 1);
        SortByName(sortedStudents);
    }
}