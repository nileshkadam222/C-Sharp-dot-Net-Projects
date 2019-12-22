package Conn;

import java.sql.Connection;
import java.sql.DriverManager;

public class GenUtility {
   String db="bus";
    String username="root";
    String password="12345";

     public Connection dbconnection()
    {
        Connection con=null;
        try {
            String url = "jdbc:mysql://localhost:3306/"+db;
            Class.forName("com.mysql.jdbc.Driver").newInstance();

             con=DriverManager.getConnection(url, username, password);


        } catch (Exception ex) {
            System.out.println("Exception "+ex);
        } 
        return con;
    }
}
