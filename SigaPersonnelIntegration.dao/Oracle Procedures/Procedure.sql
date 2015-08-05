create or replace procedure P_AMC_PERSONNEL_INTEGRATION 
(V_DATA IN VARCHAR2, V_LOTE IN VARCHAR2, V_SUBLOTE IN VARCHAR2, V_DOC IN VARCHAR2, 
 V_LINHA IN VARCHAR2, V_MOEDA IN VARCHAR2, V_DC IN VARCHAR2, V_CTADEB IN VARCHAR2, 
 V_CTACRED IN VARCHAR2, V_VALOR IN VARCHAR2, V_HISTORICO IN VARCHAR2, V_CCD  IN VARCHAR2, 
 V_CCC IN VARCHAR2,V_EMPORI IN VARCHAR2, V_FILORI IN VARCHAR2, V_TPSALD IN VARCHAR2, V_SEQ  IN VARCHAR2, 
 V_MANUAL IN VARCHAR2, V_ORIGEM IN VARCHAR, V_ROTINA IN VARCHAR2, V_AGLUTINA IN VARCHAR2, V_LP IN VARCHAR2, 
 V_SEQHIST IN VARCHAR2, V_SEQLAN IN VARCHAR2, V_CRCONV IN VARCHAR2, V_DATAV IN VARCHAR2, V_MLTSALD IN VARCHAR2, 
 V_CTLSALD IN VARCHAR2, V_USERGI IN VARCHAR2, V_MSFIL IN VARCHAR2) is
begin
  

    INSERT INTO CT2010(
           CT2_FILIAL, CT2_DCD, CT2_DCC,CT2_MOEDAS, CT2_HP,CT2_CLVLDB,CT2_CLVLCR, 
           CT2_ATIVDE,CT2_ATIVCR,CT2_INTERC,CT2_IDENTC,CT2_DTVENC,CT2_SLBASE,CT2_DTLP, 
           CT2_DATATX, CT2_TAXA, CT2_CRITER, CT2_VLR01, CT2_VLR02,CT2_VLR03 ,CT2_VLR04,
           CT2_VLR05,CT2_KEY, CT2_SEGOFI ,CT2_SEQIDX,D_E_L_E_T_,R_E_C_D_E_L_,CT2_CODCLI, 
           CT2_CODFOR,  CT2_DIACTB, CT2_CONFST, CT2_OBSCNF,CT2_NODIA,CT2_USRCNF ,CT2_DTCONF,
           CT2_HRCONF,CT2_CODPAR,CT2_AT01DB,CT2_AT01CR,CT2_AT02DB,CT2_AT02CR,CT2_AT03DB,CT2_AT03CR,
           CT2_AT04DB,CT2_AT04CR,CT2_USERGA,CT2_ITEMD,CT2_ITEMC,CT2_DEBIT2, CT2_CREDI2,CT2_CCD2, 
           CT2_CCC2,CT2_HIST2,CT2_VALOR2,CT2_CTRLSD,CT2_MOEFDB,CT2_MOEFCR, R_E_C_N_O_, CT2_DATA, 
           CT2_LOTE, CT2_SBLOTE, CT2_DOC, CT2_LINHA, CT2_MOEDLC, CT2_DC, CT2_DEBITO, CT2_CREDIT, 
           CT2_VALOR, CT2_HIST,CT2_CCD, CT2_CCC, CT2_EMPORI, CT2_FILORI, CT2_TPSALD, CT2_SEQUEN, 
           CT2_MANUAL, CT2_ORIGEM, CT2_ROTINA, CT2_AGLUT,CT2_LP, CT2_SEQHIS, CT2_SEQLAN, CT2_CRCONV, 
           CT2_DTCV3, CT2_MLTSLD, CT2_CTLSLD, CT2_USERGI, CT2_MSFIL)
    VALUES(' ', ' ', ' ', '     ', '888', '         ' ,'         ','                                        ',
           '                                        ',  ' ' ,'                                                  ',
           '        ',' ','        ','        ','0','    ','0','0','0','0','0','                                                                                                                                                                                                        ',
           '          ','     ',' ','0','      ','      ','  ',' ','                                        ','          ',
           '               ','        ','          ','      ','                    ','                    ','                    ',
           '                    ','                    ','                    ','                    ','                    ','                 ',
           '                    ','                    ','                    ','                    ','         ','         ','                                        ',
           '0',' ','  ','  ',(select max(r_e_c_n_o_)+1 from CT2010), V_DATA, V_LOTE, V_SUBLOTE, V_DOC, V_LINHA, V_MOEDA, V_DC, V_CTADEB, V_CTACRED, TO_CHAR(V_VALOR, '99999999999,99'), V_HISTORICO, V_CCD, V_CCC, 
           V_EMPORI, V_FILORI, V_TPSALD, V_SEQ, V_MANUAL, V_ORIGEM, V_ROTINA, V_AGLUTINA, V_LP, V_SEQHIST, V_SEQLAN, V_CRCONV, V_DATAV, V_MLTSALD, V_CTLSALD, V_USERGI, V_MSFIL
    );  

    commit;
       
  
end P_AMC_PERSONNEL_INTEGRATION;