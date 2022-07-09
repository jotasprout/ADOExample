using Models;
using DataAccess;

TodoDAO todoDAO = new TodoDAOImpl();
Todo Task = new Todo("Do Dishes");
bool newTodo = todoDAO.CreateTodo(Task);
todoDAO.DeleteOneTodo(1);
List<Todo> todos = todoDAO.GetAllTodos();

foreach(Todo todo in todos){
    Console.WriteLine(todo);
}