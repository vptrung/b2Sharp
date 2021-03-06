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

public class b2StackAllocator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2StackAllocator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2StackAllocator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2StackAllocator() {
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
          Box2DPINVOKE.delete_b2StackAllocator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public b2StackAllocator() : this(Box2DPINVOKE.new_b2StackAllocator(), true) {
  }

  public SWIGTYPE_p_void Allocate(int size) {
    global::System.IntPtr cPtr = Box2DPINVOKE.b2StackAllocator_Allocate(swigCPtr, size);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public void Free(SWIGTYPE_p_void p) {
    Box2DPINVOKE.b2StackAllocator_Free(swigCPtr, SWIGTYPE_p_void.getCPtr(p));
  }

  public int GetMaxAllocation() {
    int ret = Box2DPINVOKE.b2StackAllocator_GetMaxAllocation(swigCPtr);
    return ret;
  }

}

}
