# 找卡 FindCard

A open lost and found cards website.

一个很简单的找卡网站，目前处于测试阶段。

公开的说，本Web/API设计没有防止恶意大量调用API的能力，也没有承载大量正常访问的能力，请善待它。

# 网页

# 网络接口

## 数据类型

### 班级信息 ClassInfo

例子：
```
{
    "ClassId" : "2022L1",
    "Info" : {
        "Name" : "2022级理科1班"
    }
}
```

* `ClassId`：班级编号。

* `Info.Name`：班级名称。

### 卡信息 CardInfo

例子：
```
{
    "CardId" : "1234567",
    "Info" : {
        "StudentId" : "2022L10001"
    }
}
```

### 失卡招领信息 FoundInfo

例子：
```
{
    "FoundId" : "20220101.1",
    "Info" : {
        "SeekerStudentId" : "2022级理科1班",
        "CardId" : "6666666"
    }
}
```

### 学生信息 StudentInfo

例子：
```
{
    "StudentId" : "1234567",
    "Info" : {
        "Name" : "雷锋"，
        "ClassId" : "2022L1"
    }
}
```

## 学生信息接口

### （数据源）推送（给找卡）模式

#### HttpStatus push(StudentInfo[] studentInfos(, string apiKey)(, string randomCode))

### （找卡）推送（给数据源）模式

## 找卡服务

### 学生信息查询

#### object query(string tableName, string keyName, string key)

### 信息登记

#### HttpStatus found(string seekerName, string cardId)

#### HttpStatus lost(string name)

# 程序接口
