/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controller;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import static java.time.Clock.system;
 
/**
 *
 * @author brucehuynh
 */
public class Connect  {

    public static Connection getSQL()throws SQLException, ClassNotFoundException {
        
      String hostName = "BRUCEHUYNHLEE";
      String sqlInstanceName = "BRUCELEE";
      String database = "CNPM";
      String userName = "sa";
      String password = "0984986nghia";
      String connectionURL = "jdbc:sqlserver://" + hostName + ":1433"
              + ";instance=" + sqlInstanceName + ";databaseName=" + database;
 
      Connection conn = DriverManager.getConnection(connectionURL, userName,password);
      return conn;
    }
    
   
    
    
    
}



