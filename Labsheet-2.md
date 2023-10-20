# COM-LAB-I-LabSheet-Week-15
## ส่งงาน
# ลิงค์
https://github.com/AnchisaPhetnoi/Project_65030289
## รูปที่ 1
![387544013_345797714780207_1634664673674829894_n](https://github.com/AnchisaPhetnoi/COM-LAB-I-LabSheet-Week-15/assets/144197034/f25842e2-b943-4506-89d1-73a8e47851b6)
## รูปที่ 2
![393774543_382518314104359_1574968454204316028_n](https://github.com/AnchisaPhetnoi/COM-LAB-I-LabSheet-Week-15/assets/144197034/ca0e8877-6ada-4738-8c75-0acdc3e33802)
## รูปที่ 3
![ภาพ](https://github.com/AnchisaPhetnoi/COM-LAB-I-LabSheet-Week-15/assets/144197034/8f3b0b51-e56d-4c92-9712-5cb46c2e445b)

![368281368_1815876448815010_285109492636123752_n](https://github.com/AnchisaPhetnoi/COM-LAB-I-LabSheet-Week-15/assets/144197034/4b6206b9-7e04-4ca8-97d6-a6c1859e37e3)
## รูปที่ 4
![393971375_267982722340826_3358165320417803358_n](https://github.com/AnchisaPhetnoi/COM-LAB-I-LabSheet-Week-15/assets/144197034/d3d8577c-5aa0-4b5c-a943-9719a7504bd5)
## รูปที่ 5
![393512814_688896163172280_9136872002075864928_n](https://github.com/AnchisaPhetnoi/COM-LAB-I-LabSheet-Week-15/assets/144197034/953a6dff-87ce-493d-920f-dd48450329a2)
## รูปที่ 6
![394118504_830784145251956_6664835602240617645_n](https://github.com/AnchisaPhetnoi/COM-LAB-I-LabSheet-Week-15/assets/144197034/069b43ff-8aee-4759-91e4-0abd61fc2831)
## รูปที่ 7
![393774543_382518314104359_1574968454204316028_n](https://github.com/AnchisaPhetnoi/COM-LAB-I-LabSheet-Week-15/assets/144197034/d1336f94-2fed-449e-8081-9aef813d4c4d)

##  C# Unit test and github CI/CD

31.ในไฟล์ UnitTest1.cs ให้เพิ่ม code สำหรับ test อีก 1  method  ดังนี้ (เพิ่มไว้บนหรือล่าง  [TestMethod] ที่มีอยู่แล้วก็ได้)

```cs
[TestMethod]
public void TestProjectMemberIds()
{
    Assert.IsTrue((int)Cases.CaseWorkers.Joe == 1);
    Assert.IsTrue((int)Cases.CaseWorkers.Jane == 2);
    Assert.IsTrue((int)Cases.CaseWorkers.Mark == 3);
}
```

- การทดสอบนี้ควรจะไม่ผ่าน เนื่องจากชื่อสมาชิกใน test กับในรายชื่อกลุ่มไม่ตรงกัน

- ให้แก้ไขให้ test ผ่าน

32.ที่บน Server ให้แก้ไขไฟล์ dotnet-desktop.yml ในส่วน `- name: Test Project Members`  (ส่วนท้ายสุดของไฟล์) ดังนี้

```yml
      - name: Test Project Members
        id: run_vstest
        working-directory: .\TestProject\\bin\Debug\net6.0
        run: vstest.console.exe TestProject.dll /Tests:TestProjectMembersCount,TestProjectMemberIds 
```

- ส่วนที่เพิ่มคือการทดสอบ `TestProjectMemberIds`

33.push การเปลี่ยนแปลงขึ้นบน  remote repository  สังเกตุและบันทึกการเปลี่ยนแปลง

- ถ้ามีการผิดพลาด เช่นชื่อของ test method หรือ  file path ให้แก้ไขให้ถูกต้อง

## การส่งงาน

ส่ง Repository ที่ทำ Lab นี้ พร้อมแสดงรูปผลการทำ automated tests ทั้งบน Visual studio และบน github แนบมาด้วย
