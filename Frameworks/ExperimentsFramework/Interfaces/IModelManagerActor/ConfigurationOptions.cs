﻿using System.Collections.Generic;

namespace AdaptiveMedicine.Experiments.ModelManagerActor {
   public class ConfigurationOptions {
      public IEnumerable<ModelInfo> ModelsInfo { get; set; }

      public class ModelInfo {
         public int Order { get; set; }
         public string Algorithm { get; set; }
      }
   }
}
