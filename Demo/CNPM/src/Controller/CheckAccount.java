/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controller;

import Bussiness.NhanVien;
import java.util.ArrayList;

/**
 *
 * @author brucehuynh
 */
public class CheckAccount {
    
    public static boolean isValid(int id , String pass){
        
        ArrayList<NhanVien> nhanvien = NhanVien.getAllNV();
        int i = 0 ;
        while(nhanvien.size() > i){
           NhanVien nv = nhanvien.get(i);
           System.out.println(nv.getMaNV() +"," +  id);
           System.out.println(nv.getMatKhau()+ "," + pass);
           if(nv.getMaNV() == id && nv.getMatKhau().trim().equals(pass))
               return true ;
           
           i++ ;
        
        }
       return false ;
    }
    
}
