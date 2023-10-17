# COM-LAB-I-LabSheet-Week-15
##  C# Unit test and github CI/CD

31. ในไฟล์ UnitTest1.cs ให้เพิ่ม code สำหรับ test อีก 1  method  ดังนี้ (เพิ่มไว้บนหรือล่าง  [TestMethod] ที่มีอยู่แล้วก็ได้) 
 
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

32.  ที่บน Server ให้แก้ไขไฟล์ dotnet-desktop.yml ในส่วน `- name: Test Project Members`  (ส่วนท้ายสุดของไฟล์) ดังนี้

```yml
      - name: Test Project Members
        id: run_vstest
        working-directory: .\TestProject\\bin\Debug\net6.0
        run: vstest.console.exe TestProject.dll /Tests:TestProjectMembersCount,TestProjectMemberIds 
```

- ส่วนที่เพิ่มคือการทดสอบ `TestProjectMemberIds`


33. push การเปลี่ยนแปลงขึ้นบน  remote repository  สังเกตุและบันทึกการเปลี่ยนแปลง

- ถ้ามีการผิดพลาด เช่นชื่อของ test method หรือ  file path ให้แก้ไขให้ถูกต้อง


## การส่งงาน

ส่ง Repository ที่ทำ Lab นี้ พร้อมแสดงรูปผลการทำ automated tests ทั้งบน Visual studio และบน github แนบมาด้วย

