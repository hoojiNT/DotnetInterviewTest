var studentList = new StudentList(30);

Console.WriteLine("| {0,-25} | {1,-10} | {2,-10} | {3,-9} | {4,-9} |", "Name", "Math", "Physic", "Chemistry", "sumary");

for (int i = 0; i < studentList.Students.Length; i++)
{
    studentList.Students[i].GetDetail();
}

studentList.Search(8);
