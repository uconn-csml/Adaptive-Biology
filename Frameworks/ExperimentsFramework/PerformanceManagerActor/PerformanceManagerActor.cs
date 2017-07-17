﻿using System.Threading.Tasks;
using AdaptiveMedicine.Experiments.Actors.Interfaces;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;
using AdaptiveMedicine.Experiments.Actors.ServiceNames;

namespace AdaptiveMedicine.Experiments.Actors {
   [ActorService(Name = PerformanceManagerService.Name)]
   [StatePersistence(StatePersistence.Persisted)]
   internal class PerformanceManagerActor: Actor, IPerformanceManagerActor {

      public PerformanceManagerActor(ActorService actorService, ActorId actorId)
          : base(actorService, actorId) {
      }

      protected override Task OnActivateAsync() {
         ActorEventSource.Current.ActorMessage(this, "Actor activated.");
         return base.OnActivateAsync();
      }

      public Task<bool> ConfigureModelsAsync() {
         return Task.FromResult<bool>(true);
      }
   }
}
