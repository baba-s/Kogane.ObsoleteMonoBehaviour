# Kogane Obsolete Mono Behaviour

MonoBehaviour のすべてのメンバーを Obsolete で使えないようにする抽象クラス

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : ObsoleteMonoBehaviour
{
    private void Start()
    {
        Debug.Log( name );
        Debug.Log( enabled );
        Debug.Log( transform );
        Debug.Log( GetComponent<Transform>() );
    }
}
```

![ScreenShot00007](https://user-images.githubusercontent.com/6134875/210162296-0afcf5b2-28b5-4db4-ad45-47b46e454351.png)
