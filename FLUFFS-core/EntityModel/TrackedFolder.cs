//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrackedFolder
    {
        public TrackedFolder()
        {
            this.SubFolders = new HashSet<TrackedFolder>();
            this.TrackedFiles = new HashSet<TrackedFile>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullPath { get; set; }
        public Nullable<int> TrackedFolderId { get; set; }
    
        public virtual Index Index { get; set; }
        public virtual ICollection<TrackedFolder> SubFolders { get; set; }
        public virtual TrackedFolder Parent { get; set; }
        public virtual ICollection<TrackedFile> TrackedFiles { get; set; }
    }
}
