# musicSchoolבית ספר לנגינהmusic-School / 
תיאור הפרויקט
בית ספר ללימודי נגינה


ישויות


מורים-name, instrument , price,  id 


תלמידים- name, instrument, age, id 


כלי נגינה למכירה- price, type, qty, id



מיפוי routes  למורים 


שליפת שמות מורים


http://musicSchool.co.il/teachers :GET


שליפת מורה לפי קוד
http://musicSchool.co.il/teachers/1  :GET
הוספת מורה
http://musicSchool.co.il/teachers POST
מחיקת מורה
http://musicSchool.co.il/teachers/1  :DELETE
עדכון מורה
http://musicSchool.co.il/teachers/1  :PUT
עדכון מחיר מורה
http://musicSchool.co.il/teachers/1/price :PUT 

מיפוי routes  לתלמידים 
שליפת שמות תלמידים
http://musicSchool.co.il/students :GET
שליפת תלמיד לפי קוד
http://musicSchool.co.il/students /1  :GET
הוספת תלמיד
http://musicSchool.co.il/students  :POST
מחיקת תלמיד
http://musicSchool.co.il/students /1  :DELETE
עדכון תלמיד
http://musicSchool.co.il/students/1  :PUT
עדכון כלי נגינה תלמיד
http://musicSchool.co.il/teachers/1/instrument  :PUT 

מיפוי routes  לכלי נגינה 
שליפת כלי נגינה
http://musicSchool.co.il/insrtruments  :GET
שליפת כלי נגינה לפי קוד
http://musicSchool.co.il/insrtruments /1  :GET
הוספת כלי נגינה
http://musicSchool.co.il/insrtruments  :POST
מחיקת כלי נגינה
http://musicSchool.co.il/insrtruments /1  :DELETE
עדכון כלי נגינה
http://musicSchool.co.il/insrtruments /1  :PUT
עדכון מחיר כלי נגינה
http://musicSchool.co.il/insrtruments /1/price :PUT 

