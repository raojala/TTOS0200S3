using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra_6_Tehtava_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Bonus+Tehtävä 5
Toteuta C#:lla ohjelma, jossa List-tietorakenteeseen lisätään satunnaisesti luotuja Person-luokan oliota 10.000 kappaletta. Person-luokan olion etunimessä on käytettävä satunnaisesti kirjaimia väliltä A-Z ja etunimen pituus on 4 merkkiä. Sukunimi samoin, mutta pituus on 10 merkkiä.

Ohjelman tulee tulostaa henkilöiden lisäykseen kulunut aika millisekunteina. Etsi tämän jälkeen tietorakenteesta 1000 satunnaista henkilöä rekisteristä etunimen perusteella. Tulosta löydettyjen henkilöiden tiedot sekä hakuun yhteensä kulunut aika millisekuntteina.

Esimerkkitoiminta:


    List Collection:
    - Adding time : xx ms
    - Persons count : 10000
    - Random person : BEBW TXNVCXLIHR AXDTRWTNXGI

    Finding persons in collection (by firstname):
    - Found person with BHWQ firstname : BHWQ CEPHQDOSKF 
    - Found person with PHOX firstname : PHOX LMWDVFJRLM 
    - Found person with AYHA firstname : AYHA VLYCIIBNKF 
    - Found person with HUTD firstname : HUTD QWAPTJLULC 
    - Found person with TICP firstname : TICP XCIFCMOTIP 
    - Found person with VLBS firstname : VLBS OUMVRNWLQE 
    - Found person with CYJF firstname : CYJF JFOCAQDVYS 
    - Found person with BRHT firstname : BRHT HDWKDCUYPG 
    - Found person with YRKR firstname : YRKR GYQEESGAEE 
    - Found person with YRSN firstname : YRSN AVKYEGIIGC 
    - Found person with WFCL firstname : WFCL WMAFGQBQYO 
    - Found person with JCBD firstname : JCBD IJFTXHDCKH 
    - Found person with UGWP firstname : UGWP LXUDEORUIB 
    - Found person with OFUD firstname : OFUD JWAHWEROWG 
    - Found person with XEBD firstname : XEBD FBFXRJLNUM 
    - Found person with FHPR firstname : FHPR WYSGRFAIEB 
    - Found person with FXTQ firstname : FXTQ MSGVBDQKNT 
    - Found person with BUFG firstname : BUFG DJMAGWILTK 
    - Found person with VTBR firstname : VTBR LMVRFWNVPO 
    - Found person with EKGJ firstname : EKGJ CDEIFGBOAV 
    - Found person with NWEO firstname : NWEO FWQOWAVVVK 
    - Found person with GQSP firstname : GQSP HYMABHVUHB 
    - Found person with OLTC firstname : OLTC IPVOSVDTVA 
    - Found person with MDGO firstname : MDGO OQFAEJPSGQ 
    - Found person with RRMM firstname : RRMM OOEPIHEHIN 
    - Found person with MOBS firstname : MOBS WUGPNCDOPD 
    - Found person with YVDB firstname : YVDB APJXIGNADC 

    - Persons tried to fiend : 1000
    - Total finding time : xx ms

    Press enter key to continue...
    
Kokeile samaa Dictionary-rakenteelle, käytä avaimena etunimeä. Muista sisällyttää rakenteeseen 10.000 alkiota ja aloittaa satunnainen haku vasta sen jälkeen. Muista, että Dictonary kokoelmassa ei voi olla kahta samaa avainta.

Esimerkkitoiminta:


    Dictionary Collection:
    - Adding time : xx ms
    - Persons count : 10000
    - Random person : SQKP BOIYJURHIE VWDMKNJPKBG

    Finding persons in collection (by firstname):
    - Found person with ENGR firstname : ENGR NYHOKHXSME 
    - Found person with QFQX firstname : QFQX BYTRKKAJDF 
    - Found person with FAQI firstname : FAQI AJYBJIDWLL 
    - Found person with JJQS firstname : JJQS WUPNIPXWHJ 
    - Found person with YWSJ firstname : YWSJ MCPRUIJPOX 
    - Found person with TTTF firstname : TTTF BVLGVOSHSA 
    - Found person with STST firstname : STST YHIALLHQJN 
    - Found person with QRJH firstname : QRJH DJDYWITDRM 
    - Found person with XCOH firstname : XCOH NIQRIACAJI 
    - Found person with NKNM firstname : NKNM LSQMRQAFPJ 
    - Found person with REVI firstname : REVI DQVFRQQGYU 
    - Found person with GVPO firstname : GVPO GQOAKJUHAH 
    - Found person with IYIQ firstname : IYIQ ASAVXHKYKQ 
    - Found person with VKHV firstname : VKHV DOVNHWOQDA 
    - Found person with WVWN firstname : WVWN TQNBJBCLNF 
    - Found person with YQPF firstname : YQPF PPOJUTJHGF 
    - Found person with DGOP firstname : DGOP ANMHNUXSIS 
    - Found person with MNGV firstname : MNGV UVWWOUKSPE 
    - Found person with YYIB firstname : YYIB FWOSQBFANJ 
    - Found person with NVVD firstname : NVVD LVFETNIVWK 
    - Found person with KDNA firstname : KDNA URXQKPIISG 
    - Found person with EKDE firstname : EKDE IQLPJAAWHI 
    - Found person with NBLY firstname : NBLY KSXSQAANTY 
    - Found person with BFSR firstname : BFSR PNCWVACIRJ 
    - Found person with UNVV firstname : UNVV RYPGKOHDJG 
    - Found person with VJPA firstname : VJPA CSFXJVQMOM 
    - Found person with QFHP firstname : QFHP FWISPWLMET 
    - Found person with DFPU firstname : DFPU TSRXGQWLQI 
    - Found person with YDXM firstname : YDXM TOHSVSAEIU 
    - Found person with MTWH firstname : MTWH OHFHXUGAAC 
    - Found person with WUAB firstname : WUAB FCDKGECMMY 
    - Found person with LATH firstname : LATH KQYLVLFONL 

    - Persons tried to fiend : 1000
    - Total finding time : xx ms

    Press enter key to continue...
    
Millaisia eroja nopeuksissa havaitsit?

 
             */
        }
    }
}
