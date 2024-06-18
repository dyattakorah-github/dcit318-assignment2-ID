public class program 
{
    public static void Main(string[] args)
    {
        Animal genAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        genAnimal.makeSound();
        dog.makeSound();
        cat.makeSound();
    }
}