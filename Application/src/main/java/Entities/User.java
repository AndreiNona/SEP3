package Entities;

public class User {
    private int userId;
    private String password;
    private String username;
    private String firstName;
    private String lastName;
    private String email;
    private int SecurityLevel;

    public User() {}

    public User(int userId, String password, String username, String firstName, String lastName) {
        this.userId = userId;
        this.password = password;
        this.username = username;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public User(int userId, String password, String username, String firstName, String lastName, String email, int securityLevel) {
        this.userId = userId;
        this.password = password;
        this.username = username;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        SecurityLevel = securityLevel;
    }

    public int getUserId() {
        return userId;
    }

    public void setUserId(int userId) {
        this.userId = userId;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public int getSecurityLevel() {
        return SecurityLevel;
    }

    public void setSecurityLevel(int securityLevel) {
        SecurityLevel = securityLevel;
    }

    @Override
    public String toString() {
        return "User{" +
                "userId=" + userId +
                ", password='" + password + '\'' +
                ", username='" + username + '\'' +
                ", firstName='" + firstName + '\'' +
                ", lastName='" + lastName + '\'' +
                ", email='" + email + '\'' +
                ", SecurityLevel=" + SecurityLevel +
                '}';
    }
}
