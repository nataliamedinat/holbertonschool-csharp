using System;

public enum Rating 
{
    Good,
    Great,
    Excellent
}
struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

 public Dog(string DogName, float DogAge, string DogOwner, Rating DogRating)
 {
    name = DogName;
    age = DogAge;
    owner = DogOwner;
    rating = DogRating;
 }


 public override string ToString()
 {
     return string.Format($"Dog name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}");
 }
}