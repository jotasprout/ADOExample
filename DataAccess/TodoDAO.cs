using Models;

public interface TodoDAO{
    List<Todo> GetAllTodos();
    bool CreateTodo(Todo todo);
    void DeleteOneTodo(int id);
}