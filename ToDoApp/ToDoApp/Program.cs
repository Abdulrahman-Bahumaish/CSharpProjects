using System.Collections;
using ToDoApp;

Tasking Task1 = new Tasking();
Task1.Name = "Writing Assingnments";
Tasking Task2 = new Tasking();
Task2.Name = "Go To shopping";
Tasking Task3 = new Tasking();
Task3.Name = "Clean the house";

TaskManager.AddTask(Task1);
TaskManager.AddTask(Task2);
TaskManager.AddTask(Task3);

TaskManager.SearchForTask(Task2);

Tasking TaskToDelete = Task1;
TaskManager.DeleteTask(TaskToDelete);
TaskManager.SearchForTask(TaskToDelete);
TaskManager.DeleteTask(Task3);