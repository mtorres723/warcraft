﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<PlayableClassesIndex>> GetPlayableClassesIndexAsync(string @namespace)
        {
            return await GetPlayableClassesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableClassesIndex>> GetPlayableClassesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PlayableClassesIndex>(region, $"{host}/data/wow/playable-class/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableClass>> GetPlayableClassAsync(int classId, string @namespace)
        {
            return await GetPlayableClassAsync(classId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableClass>> GetPlayableClassAsync(int classId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PlayableClass>(region, $"{host}/data/wow/playable-class/{classId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableClassMedia>> GetPlayableClassMediaAsync(int classId, string @namespace)
        {
            return await GetPlayableClassMediaAsync(classId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PlayableClassMedia>> GetPlayableClassMediaAsync(int classId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PlayableClassMedia>(region, $"{host}/data/wow/media/playable-class/{classId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpTalentSlots>> GetPvpTalentSlotsAsync(int classId, string @namespace)
        {
            return await GetPvpTalentSlotsAsync(classId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PvpTalentSlots>> GetPvpTalentSlotsAsync(int classId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PvpTalentSlots>(region, $"{host}/data/wow/playable-class/{classId}/pvp-talent-slots?namespace={@namespace}&locale={locale}");
        }
    }
}
