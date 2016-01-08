/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Bussiness;

import Controller.Connect;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

/**
 *
 * @author brucehuynh
 */
public class ChucVu {
    private String ChucVu ;
    private String Luong ;
    
    
    public static Vector getChucVu(){
        try {
            String sql = "Select Chucvu from ChucVu " ;
            Vector v = new Vector();
            ResultSet rs = Connect.getSQL().createStatement().executeQuery(sql);
            
            while(rs.next()){
                v.add(rs.getString(1));
            }
            return v ;
        } catch (Exception ex) {
            ex.printStackTrace();
            JOptionPane.showMessageDialog(null, "load chức vụ fail :v");
        }
       return null ;
    }
}
