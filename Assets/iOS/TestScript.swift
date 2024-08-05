@_cdecl("TestScript_NSLog")
public func TestScript_NSLog(text: UnsafePointer<CChar>) {
    NSLog(String(cString: text))
}