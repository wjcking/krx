
using System;
//Dct.Mbd.Mem.Cache ?
//Dnk:Ding~New-Ker Value~New-Static
public struct aoz
{
    static ket ket()
    {
        ket n = new ket();
        //  ket n = null;//如果是值类型 可以
        n.zeo = "0";
        n.one = "1"; n.two = "2"; n.thr = "3";
        n.fou = "4"; n.fiv = "5"; n.six = "6";
        n.sev = "7"; n.eht = "8"; n.nin = "9";

        n.csa = "a"; n.csb = "b"; n.csc = "c"; n.csd = "d";
        n.cse = "e"; n.csf = "f"; n.csg = "g"; n.csh = "h";
        n.csi = "i"; n.csj = "j"; n.csk = "k"; n.csl = "l";
        n.csm = "m"; n.csn = "n"; n.cso = "o"; n.csp = "p";
        n.csq = "q"; n.csr = "r"; n.css = "s"; n.cst = "t";
        n.csu = "u"; n.csv = "v"; n.csw = "w"; n.csx = "x";
        n.csy = "y"; n.csz = "z";

        n.cba = "A"; n.cbb = "B"; n.cbc = "C"; n.cbd = "D";
        n.cbe = "E"; n.cbf = "F"; n.cbg = "G"; n.cbh = "H";
        n.cbi = "I"; n.cbj = "J"; n.cbk = "K"; n.cbl = "L";
        n.cbm = "M"; n.cbn = "N"; n.cbo = "O"; n.cbp = "P";
        n.cbq = "Q"; n.cbr = "R"; n.cbs = "S"; n.cbt = "T";
        n.cbu = "U"; n.cbv = "V"; n.cbw = "W"; n.cbx = "X";
        n.cby = "Y"; n.cbz = "Z";
        //Connector cot  separator sot
        n.cnt = "-";
        n.cnr = "~";
        n.ace = " "; n.con = ":";
        n.cma = ","; n.com = ";";
        n.duo = "."; n.dsh = "/";
        n.spt = "|";

        n.lsm = "("; n.lmd = "["; n.lbr = "{"; n.lkt = "<"; n.qod = '"'.ToString();
        n.rsm = ")"; n.rmd = "]"; n.rbr = "}"; n.rkt = ">"; n.qos = "`";
        //计算机运算符号和现实纸张相符的只有+
        n.cpp = "+";

        n.alm = "!"; n.per = "%";
        n.csp = "#"; n.and = "&";
        n.dor = "$";
        n.sqt = "\"";

        n.sdr = "*";
        n.eqt = "=";
        n.qst = "?";
        n.atr = "@";
        n.dsa = "\\";
        n.art = "^";
        n.udr = "_";

        return n;
    }
    public static implicit operator aoz(Type value)
    { 
        switch(value.Name)
        {
            case "ket":  aoz.ket(); break;
            case "ket2": aoz.ket(); break;
            case "ket3": aoz.ket(); break;
            case "ket4": aoz.ket(); break;
            case "ket5": aoz.ket(); break;
            case "ket6": aoz.ket(); break;
            case "ket7": aoz.ket(); break;
            case "ket8": aoz.ket(); break;
        }
        return value;
    }
}

