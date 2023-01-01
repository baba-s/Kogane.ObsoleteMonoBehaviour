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