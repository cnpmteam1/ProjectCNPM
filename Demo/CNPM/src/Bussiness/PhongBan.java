/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Bussiness;

import Controller.Connect;
import java.sql.Date;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

/**
 *
 * @author brucehuynh
 */
public class PhongBan {
    private String MaPhong ;
    private String TenPhong ;
    private String ChucNang ;
    private int SoDT ;
    private String Email ;
    private Date NgayTL  ;
    private String GhiChu ;
    
    public PhongBan(String MaPhong , String TenPhong){
       this.MaPhong = MaPhong ;
       this.TenPhong = TenPhong ;
    }
    public static ArrayList<PhongBan> getPhongBan(){
        ArrayList<PhongBan> phongban = new ArrayList<>();
        try {
            String sql = "select MaPhong , TenPhong  from PhongBan " ;
            ResultSet rs = Connect.getSQL().createStatement().executeQuery(sql);
            
            while(rs.next()){
                
                PhongBan pb = new PhongBan(rs.getString(1), rs.getString(2));
                phongban.add(pb);
                
            }
            return phongban ;
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(null,"Get phongban fail ");
            return null ;
        }
    
    }

    /**
     * @return the MaPhong
     */
    public String getMaPhong() {
        return MaPhong;
    }

    /**
     * @param MaPhong the MaPhong to set
     */
    public void setMaPhong(String MaPhong) {
        this.MaPhong = MaPhong;
    }

    /**
     * @return the TenPhong
     */
    public String getTenPhong() {
        return TenPhong;
    }

    /**
     * @param TenPhong the TenPhong to set
     */
    public void setTenPhong(String TenPhong) {
        this.TenPhong = TenPhong;
    }

    /**
     * @return the ChucNang
     */
    public String getChucNang() {
        return ChucNang;
    }

    /**
     * @param ChucNang the ChucNang to set
     */
    public void setChucNang(String ChucNang) {
        this.ChucNang = ChucNang;
    }

    /**
     * @return the SoDT
     */
    public int getSoDT() {
        return SoDT;
    }

    /**
     * @param SoDT the SoDT to set
     */
    public void setSoDT(int SoDT) {
        this.SoDT = SoDT;
    }

    /**
     * @return the Email
     */
    public String getEmail() {
        return Email;
    }

    /**
     * @param Email the Email to set
     */
    public void setEmail(String Email) {
        this.Email = Email;
    }

    /**
     * @return the NgayTL
     */
    public Date getNgayTL() {
        return NgayTL;
    }

    /**
     * @param NgayTL the NgayTL to set
     */
    public void setNgayTL(Date NgayTL) {
        this.NgayTL = NgayTL;
    }

    /**
     * @return the GhiChu
     */
    public String getGhiChu() {
        return GhiChu;
    }

    /**
     * @param GhiChu the GhiChu to set
     */
    public void setGhiChu(String GhiChu) {
        this.GhiChu = GhiChu;
    }
}
