//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace b2Sharp {

public class b2ContactRegister : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2ContactRegister(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2ContactRegister obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2ContactRegister() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2ContactRegister(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_f_p_b2Fixture_int32_p_b2Fixture_int32_p_b2BlockAllocator__p_b2Contact createFcn {
    set {
      Box2DPINVOKE.b2ContactRegister_createFcn_set(swigCPtr, SWIGTYPE_p_f_p_b2Fixture_int32_p_b2Fixture_int32_p_b2BlockAllocator__p_b2Contact.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2ContactRegister_createFcn_get(swigCPtr);
      SWIGTYPE_p_f_p_b2Fixture_int32_p_b2Fixture_int32_p_b2BlockAllocator__p_b2Contact ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_b2Fixture_int32_p_b2Fixture_int32_p_b2BlockAllocator__p_b2Contact(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_b2Contact_p_b2BlockAllocator__void destroyFcn {
    set {
      Box2DPINVOKE.b2ContactRegister_destroyFcn_set(swigCPtr, SWIGTYPE_p_f_p_b2Contact_p_b2BlockAllocator__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2ContactRegister_destroyFcn_get(swigCPtr);
      SWIGTYPE_p_f_p_b2Contact_p_b2BlockAllocator__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_b2Contact_p_b2BlockAllocator__void(cPtr, false);
      return ret;
    } 
  }

  public bool primary {
    set {
      Box2DPINVOKE.b2ContactRegister_primary_set(swigCPtr, value);
    } 
    get {
      bool ret = Box2DPINVOKE.b2ContactRegister_primary_get(swigCPtr);
      return ret;
    } 
  }

  public b2ContactRegister() : this(Box2DPINVOKE.new_b2ContactRegister(), true) {
  }

}

}