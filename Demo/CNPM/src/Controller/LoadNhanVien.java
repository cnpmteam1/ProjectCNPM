/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controller;

import Bussiness.ChucVu;
import Bussiness.NhanVien;
import Bussiness.PhongBan;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JComboBox;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author brucehuynh
 */
public class LoadNhanVien {
     public static void  show(DefaultTableModel model,ArrayList<NhanVien> nhanvien){
      
        
             int i = 0 ;
            while(model.getRowCount() > 0)
             model.removeRow(0);
             while(i < nhanvien.size()){
                 
                 Vector data = new Vector();
                 
                 NhanVien nv = nhanvien.get(i);
                 
                 data.add(nv.getMaNV());
                 data.add(nv.getTenNV());
                 data.add(nv.getTrangThai());
                 data.add(nv.getSDT());
                 data.add(nv.getChucVuID());
                 data.add(nv.getMaPhongID());
                 
                 model.addRow(data);
           
                 i++ ;
     
     }
    }
     
     
     public static void loadChucvu(JComboBox combo){
         Vector v = ChucVu.getChucVu() ;
         int i = 0 ;
         combo.removeAllItems();
         while(v.size()>i){
            combo.addItem(v.get(i));
            i++ ;
         }
     
     }
     
     public static void loadPhongBan(JComboBox combo , ArrayList<PhongBan> pb){
         int i = 0 ;
         combo.removeAllItems();
         while(pb.size() > i){
            combo.addItem(pb.get(i).getTenPhong());
            i++ ;
         }
         
     
     }
     
     
}
