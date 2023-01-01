using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedParameter.Global
// ReSharper disable InconsistentNaming

namespace Kogane
{
    public abstract class ObsoleteMonoBehaviour : MonoBehaviour
    {
        // MonoBehaviour
        [Obsolete( "", true )] public new bool      IsInvoking()                                                                => throw new NotImplementedException();
        [Obsolete( "", true )] public new void      CancelInvoke()                                                              => throw new NotImplementedException();
        [Obsolete( "", true )] public new void      Invoke( string                   methodName, float time )                   => throw new NotImplementedException();
        [Obsolete( "", true )] public new void      InvokeRepeating( string          methodName, float time, float repeatRate ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new void      CancelInvoke( string             methodName )               => throw new NotImplementedException();
        [Obsolete( "", true )] public new bool      IsInvoking( string               methodName )               => throw new NotImplementedException();
        [Obsolete( "", true )] public new Coroutine StartCoroutine( string           methodName )               => throw new NotImplementedException();
        [Obsolete( "", true )] public new Coroutine StartCoroutine( string           methodName, object value ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new Coroutine StartCoroutine( IEnumerator      routine )    => throw new NotImplementedException();
        [Obsolete( "", true )] public new Coroutine StartCoroutine_Auto( IEnumerator routine )    => throw new NotImplementedException();
        [Obsolete( "", true )] public new void      StopCoroutine( IEnumerator       routine )    => throw new NotImplementedException();
        [Obsolete( "", true )] public new void      StopCoroutine( Coroutine         routine )    => throw new NotImplementedException();
        [Obsolete( "", true )] public new void      StopCoroutine( string            methodName ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new void      StopAllCoroutines()                           => throw new NotImplementedException();

        [Obsolete( "", true )] public new bool useGUILayout  { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Obsolete( "", true )] public new bool runInEditMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Behaviour
        [Obsolete( "", true )] public new bool enabled            { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Obsolete( "", true )] public new bool isActiveAndEnabled => throw new NotImplementedException();

        // Component
        [Obsolete( "", true )] public new Transform  transform      => throw new NotImplementedException();
        [Obsolete( "", true )] public new GameObject gameObject     => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  rigidbody      => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  rigidbody2D    => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  camera         => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  light          => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  animation      => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  constantForce  => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  renderer       => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  audio          => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  networkView    => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  collider       => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  collider2D     => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  hingeJoint     => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component  particleSystem => throw new NotImplementedException();

        [Obsolete( "", true )] public new string tag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Obsolete( "", true )] public new Component   GetComponent( Type type )                                       => throw new NotImplementedException();
        [Obsolete( "", true )] public new T           GetComponent<T>()                                               => throw new NotImplementedException();
        [Obsolete( "", true )] public new bool        TryGetComponent( Type           type, out Component component ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new bool        TryGetComponent<T>( out T       component )               => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component   GetComponent( string            type )                    => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component   GetComponentInChildren( Type    t, bool includeInactive ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component   GetComponentInChildren( Type    t )                        => throw new NotImplementedException();
        [Obsolete( "", true )] public new T           GetComponentInChildren<T>( bool includeInactive )          => throw new NotImplementedException();
        [Obsolete( "", true )] public new T           GetComponentInChildren<T>()                                => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component[] GetComponentsInChildren( Type    t, bool includeInactive ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component[] GetComponentsInChildren( Type    t )                               => throw new NotImplementedException();
        [Obsolete( "", true )] public new T[]         GetComponentsInChildren<T>( bool includeInactive )                 => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        GetComponentsInChildren<T>( bool includeInactive, List<T> result ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new T[]         GetComponentsInChildren<T>()                                  => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        GetComponentsInChildren<T>( List<T> results )                 => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component   GetComponentInParent( Type          t, bool includeInactive ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component   GetComponentInParent( Type          t )                  => throw new NotImplementedException();
        [Obsolete( "", true )] public new T           GetComponentInParent<T>( bool       includeInactive )    => throw new NotImplementedException();
        [Obsolete( "", true )] public new T           GetComponentInParent<T>()                                => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component[] GetComponentsInParent( Type    t, bool includeInactive ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new T[]         GetComponentsInParent<T>( bool includeInactive )                  => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        GetComponentsInParent<T>( bool includeInactive, List<T> results ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new T[]         GetComponentsInParent<T>()                                => throw new NotImplementedException();
        [Obsolete( "", true )] public new Component[] GetComponents( Type       type )                          => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        GetComponents( Type       type, List<Component> results ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        GetComponents<T>( List<T> results )                                               => throw new NotImplementedException();
        [Obsolete( "", true )] public new T[]         GetComponents<T>()                                                                => throw new NotImplementedException();
        [Obsolete( "", true )] public new bool        CompareTag( string         tag )                                                  => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        SendMessageUpwards( string methodName, object value, SendMessageOptions options ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        SendMessageUpwards( string methodName, object value ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        SendMessageUpwards( string methodName )                             => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        SendMessageUpwards( string methodName, SendMessageOptions options ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        SendMessage( string        methodName, object             value )   => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        SendMessage( string        methodName )                                                       => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        SendMessage( string        methodName, object             value, SendMessageOptions options ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        SendMessage( string        methodName, SendMessageOptions options )   => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        BroadcastMessage( string   methodName, object             parameter ) => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        BroadcastMessage( string   methodName )                                                           => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        BroadcastMessage( string   methodName, SendMessageOptions options )                               => throw new NotImplementedException();
        [Obsolete( "", true )] public new void        BroadcastMessage( string   methodName, object             parameter, SendMessageOptions options ) => throw new NotImplementedException();

        // Object
        [Obsolete( "", true )] public new string    name      { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Obsolete( "", true )] public new HideFlags hideFlags { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public new int GetInstanceID() => throw new NotImplementedException();
    }
}