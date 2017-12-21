using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace propterHoc {
    public class SaveFileEditor {

        public bool IsSaveLoaded { get; private set; } = false;
        public event EventHandler<SaveLoadedEventArgs> SaveLoaded;
        private WorldData _data;

        protected virtual void OnSaveLoaded(SaveLoadedEventArgs e) {
            SaveLoaded?.Invoke(this, e);
        }

        public class SaveLoadedEventArgs : EventArgs { }

        public SaveFileEditor() {
            BackupDirectory = BackupDirectoryDefault;
        }

        
        public string BackupDirectoryDefault { get; } =  nameof(propterHoc)+"backup";
        public string BackupDirectory { get; set; }
        public int MaxNumberOfBackups { get; set; } = 2;


        public bool LoadSave(string fileName, bool backup = true) {
            if (!File.Exists(fileName)) {
                Trace.WriteLine("Failed to find specified file", "[INFO]");
                return false;
            }



            if (backup) {
                string saveName = Path.GetFileNameWithoutExtension(fileName);
                string directory = Path.GetDirectoryName(fileName);

                string backupDirectory = BackupDirectory == BackupDirectoryDefault ? Path.Combine(directory, BackupDirectory) : BackupDirectory;

                if (!Directory.Exists(backupDirectory)) {
                    Directory.CreateDirectory(backupDirectory);
                }
                else {
                    var files = Directory.GetFiles(directory, "*.xml", SearchOption.TopDirectoryOnly);
                    if (files.Length >= MaxNumberOfBackups) {
                        DateTime oldest = DateTime.UtcNow;
                        string oldFile ="";

                        foreach (string file in files) {
                            var time = Directory.GetLastWriteTimeUtc(file);
                            if (time >= oldest) continue;

                            oldest = time;
                            oldFile = file;
                        }
                        File.Delete(oldFile);
                    }
                }
                
                var backupFile = saveName + "_backup" + Guid.NewGuid() + Path.GetExtension(fileName);
                File.Copy(fileName, Path.Combine(backupDirectory, backupFile), true);
                
            }



            var ser = new XmlSerializer(typeof(WorldData), Serialization.Types.ToArray());
            //var ns = new XmlSerializerNamespaces();

            //var ser = new XmlSerializer(typeof(WorldData));
            using (XmlReader reader = XmlReader.Create(fileName)) {
               _data = (WorldData) ser.Deserialize(reader);
            }


            IsSaveLoaded = true;
            OnSaveLoaded(new SaveLoadedEventArgs());
            return true;
        }

        public bool WriteSave(string fileName, bool overwrite = false) {

            if (File.Exists(fileName) && !overwrite) {
                Trace.WriteLine("Save file already exists at location, and overwrite is set to false", "[INFO]");
                return false;
            }

            

            //XmlSerializer ser = new XmlSerializer(typeof(WorldData));
            //try {
            //    using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
            //        using (XmlWriter writer = XmlWriter.Create(fs, new XmlWriterSettings {Indent = true})) {
            //            ser.Serialize(writer, _data);
            //        }
            //    }
            //}
            //catch (System.Security.SecurityException ex) {
            //    Trace.WriteLine("Did not have required permission to access file", "[INFO]");
            //    Trace.WriteLine(ex.Message, "[DEBUG]");
            //    return false;
            //}
            return true;
        }

        /*
        public StructureSaveData SelectComputerByName(string name) {

            return (StructureSaveData) _data.Things.FirstOrDefault(x =>
                x.GetType() == typeof(StructureSaveData) && x.PrefabName == "StructureComputer" &&
                x.CustomName == name);

        }

        public T SelectSingleThing<T>(Func<WorldDataThingsThingSaveData, bool> wherePredicate) where  T : WorldDataThingsThingSaveData {
            return (T) _data.Things.FirstOrDefault(e => e.GetType() == typeof(T) && wherePredicate(e));
        }

        public List<string> GetThingsReferenceIDs(Func<WorldDataThingsThingSaveData, bool> wherePredicate ) {

            return _data.Things.Where(wherePredicate).Select(x => x.ReferenceId).ToList();
        }
        */

    }
}
