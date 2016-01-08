/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Bussiness;

import Controller.Connect;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

/**
 *
 * @author brucehuynh
 */
public class NhanVien {
    private String MaNV ;
    private String TenNV ;
    private Date NgaySinh ;
    private String SDT ;
    private String SoCMT ;
    private String TrangThai ;
    private Date NgayBatDau ;
    private Date NgayKetThuc ;
    private String MatKhau ;
    private String GhiChu ;
    private String ChucVuID ;
    private String MaPhongID ;

    
    
    public NhanVien(String MaNV, String TenNV, Date NgaySinh, String SDT, String SoCMT, String TrangThai, Date NgayBatDau, Date NgayKetThuc, String MatKhau, String GhiChu, String ChucVuID, String MaPhongID) {
        this.MaNV = MaNV;
        this.TenNV = TenNV;
        this.NgaySinh = NgaySinh;
        this.SDT = SDT;
        this.SoCMT = SoCMT;
        this.TrangThai = TrangThai;
        this.NgayBatDau = NgayBatDau;
        this.NgayKetThuc = NgayKetThuc;
        this.MatKhau = MatKhau;
        this.GhiChu = GhiChu;
        this.ChucVuID = ChucVuID;
        this.MaPhongID = MaPhongID;
    }

   
    
    public NhanVien(){
    
    }
    
    
    public String getMaNV() {
        return MaNV;
    }

    public void setMaNV(String MaNV) {
        this.MaNV = MaNV;
    }

    public String getTenNV() {
        return TenNV;
    }

    public void setTenNV(String TenNV) {
        this.TenNV = TenNV;
    }

    public Date getNgaySinh() {
        return NgaySinh;
    }

    public void setNgaySinh(Date NgaySinh) {
        this.NgaySinh = NgaySinh;
    }

    public String getSDT() {
        return SDT;
    }

    public void setSDT(String SDT) {
        this.SDT = SDT;
    }

    public String getSoCMT() {
        return SoCMT;
    }

    public void setSoCMT(String SoCMT) {
        this.SoCMT = SoCMT;
    }

    public String getTrangThai() {
        return TrangThai;
    }

    public void setTrangThai(String TrangThai) {
        this.TrangThai = TrangThai;
    }

    public Date getNgayBatDau() {
        return NgayBatDau;
    }

    public void setNgayBatDau(Date NgayBatDau) {
        this.NgayBatDau = NgayBatDau;
    }

    public Date getNgayKetThuc() {
        return NgayKetThuc;
    }

    public void setNgayKetThuc(Date NgayKetThuc) {
        this.NgayKetThuc = NgayKetThuc;
    }

    public String getMatKhau() {
        return MatKhau;
    }

    public void setMatKhau(String MatKhau) {
        this.MatKhau = MatKhau;
    }

    public String getGhiChu() {
        return GhiChu;
    }

    public void setGhiChu(String GhiChu) {
        this.GhiChu = GhiChu;
    }

    public String getChucVuID() {
        return ChucVuID;
    }

    public void setChucVuID(String ChucVuID) {
        this.ChucVuID = ChucVuID;
    }

    public String getMaPhongID() {
        return MaPhongID;
    }

    public void setMaPhongID(String MaPhongID) {
        this.MaPhongID = MaPhongID;
    }

    
    

   
    public static ArrayList<NhanVien> FindNV(int temp , String key){
        ArrayList<NhanVien> nhanvien = null ;
        try {
            String sql = null ;
            nhanvien = new ArrayList<NhanVien>();
            if(temp == 0) sql = "Select * from NhanVien where MaNhanVien like '" + key +"'" ;
            else sql = "Select * from NhanVien where TenNhanVien like '" + key + "'" ;
            
            ResultSet rs = Connect.getSQL().createStatement().executeQuery(sql);
            
            while(rs.next()){
                
                NhanVien nv = new NhanVien();
                nv.setMaNV(rs.getString(1));
                nv.setTenNV(rs.getNString(2));
                nv.setNgaySinh(rs.getDate(3));
                nv.setSDT(rs.getString(4));
                nv.setSoCMT(rs.getString(5));
                nv.setGhiChu(rs.getNString(6));
                nv.setTrangThai(rs.getString(7));
                nv.setNgayBatDau(rs.getDate(8));
                nv.setNgayKetThuc(rs.getDate(9));
                nv.setMatKhau(rs.getString(10));
                nv.setChucVuID(rs.getString(11));
                nv.setMaPhongID(rs.getString(12));
                nhanvien.add(nv);
                
            }
          
        } catch (Exception ex) {
           ex.printStackTrace();
           JOptionPane.showMessageDialog(null,"Find fail");
        }
       
       return nhanvien ;
    } 
    
    public void InsertNV() throws ClassNotFoundException, SQLException {
     
            String sql = "Insert into NhanVien values(?,?,?,?,?,?,?,?,?,?,?,?)" ;
            DateFormat fm = new SimpleDateFormat("MM/dd/yyyy");
            PreparedStatement ps = Connect.getSQL().prepareStatement(sql);
            ps.setString(1,getMaNV());
            ps.setString(2,getTenNV());
            ps.setString(3, fm.format(getNgaySinh()));
            ps.setString(4,getSDT());
            ps.setString(5,getSoCMT());
            ps.setString(6, getGhiChu());
            ps.setString(7 , getTrangThai());
            ps.setString(8, fm.format(getNgayBatDau()));
            ps.setString(9, fm.format(getNgayKetThuc()));
            ps.setString(10 ,getMatKhau());
            ps.setString(11, getChucVuID());
            ps.setString(12, getMaPhongID());
            ps.execute();
       
    }
    
    
    // get all the employer
    public static ArrayList<NhanVien> getAllNV() {
        ArrayList<NhanVien> nhanvien = null ;
        try {
            nhanvien = new ArrayList<NhanVien>();
            String sql = "Select * from NhanVien";
            ResultSet rs = Connect.getSQL().createStatement().executeQuery(sql);
            
            while(rs.next()){
                
                NhanVien nv = new NhanVien();
                nv.setMaNV(rs.getString(1));
                nv.setTenNV(rs.getNString(2));
                nv.setNgaySinh(rs.getDate(3));
                nv.setSDT(rs.getString(4));
                nv.setSoCMT(rs.getString(5));
                nv.setGhiChu(rs.getNString(6));
                nv.setTrangThai(rs.getString(7));
                nv.setNgayBatDau(rs.getDate(8));
                nv.setNgayKetThuc(rs.getDate(9));
                nv.setMatKhau(rs.getString(10));
                nv.setChucVuID(rs.getString(11));
                nv.setMaPhongID(rs.getString(12));
                nhanvien.add(nv);
                
            }
            
        } catch (Exception e) {
               e.printStackTrace();
               JOptionPane.showMessageDialog(null,"Load data fails");
        }
      return nhanvien ;
    
    }

}

