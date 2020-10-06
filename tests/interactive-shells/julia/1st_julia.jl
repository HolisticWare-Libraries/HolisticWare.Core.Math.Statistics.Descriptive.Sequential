data = open("../../../externals/Core.Math.Samples/data/Pejcic_318.csv", "r") do f   # "r" for reading
    filecontent = read(f,String) # attention that it can be used only once. The second time, without reopening the file, read() would return an empty string
    print(filecontent)
  end