## ��� introduction

promise��װ 
1. ��Ҫtry catch
2. no try catch
3. ����[err,back] 
4. reback [err,back]
5. if(err)�澯Ȼ�󷵻ؼ���;Ȼ��ʹ��backֵ
6. if(err)warn and return  ;get back 

## ���ö� apply

**use for `js ts` project**

|��|֧��|
|---|---|
|Web|��|
|΢��С����|��|
|iOS|��|
|Android|��|

## ���� rely on

nothing



## ���� props

nothing

## ���� method

nothing

## DEMO 

```js
...

import Promise78 from "@www778878net/promise78"
function test() {
    return new Promise78((resolve, reject) => {
        setTimeout(() => {
            reject("testerr")
        }, 1000)
    })
}
let [err, back] = await test(); 
if(err){
    console.log(err)
    return
}

...
```

## OTHER
https://github.com/www778878net/promise78.git
you can see test/test.js
