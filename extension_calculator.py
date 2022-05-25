
extensions_buffer = []

extensions = [".iso", ".adf", ".dsk", ".cpc", ".dsk", ".bin", ".a26", ".rom", ".a52", ".bas", ".bin", ".xex", ".atr", ".xfd", ".dcm", ".atr.gz", ".xfd.gz", ".a78", ".bin", ".j64", ".jag", ".lnx", ".st", ".stx", ".img", ".rom", ".raw", ".ipf", ".ctr", ".bin", ".col", ".rom", ".zip", ".cas", ".wav", ".bas," ".asc", ".dmk", ".jvc", ".os9", ".dsk", ".vdk", ".rom", ".ccc", ".cna", ".crt", ".d64", ".g64", "t64", ".tap", ".x64", ".cdi", ".gdi", ".gba", ".iso", ".gg", ".gb", ".gbc", ".smd", ".bin", ".md", ".iso", ".int", ".bin", ".img", ".rom", ".zip" ".sms", ".rom", ".mx1", ".mx2", ".col", ".dsk", ".zip", ".ngp", ".ngc", ".z64", ".n64", ".v64", ".nds", ".bin", ".zip", ".nes", ".smc", ".sfc", ".fig", ".swc", ".mgd", ".dsk", ".tap", ".com", ".sh", ".bat", ".exe", ".pce", ".bin", ".cue", ".img", ".mdf", ".dsk", ".mgt", ".sbt", ".sad", ".32x", ".smd", ".bin", ".md", ".smd", ".bin", ".md", ".iso", ".sg", ".zip", ".zip", ".smc", ".sfc", ".fig", ".swc", ".ctg", ".dsk", ".vsc", ".gam", ".bin", ".vb", ".iso", ".ws", ".wsc", ".sna", ".szx", ".z80", ".tap", ".tzx", ".z80", ".udi", ".mgt", ".img", ".trd", ".scl", ".dsk"]

for extension in extensions:
    if extension not in extensions_buffer:
        extensions_buffer.append(extension)

extensions_buffer = list(set(extensions_buffer));

for extension in extensions_buffer:
    print(extension)



