﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<CharacterEncountersSummary>> GetCharacterEncountersSummaryAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterEncountersSummaryAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterEncountersSummary>> GetCharacterEncountersSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterEncountersSummary>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/encounters?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterDungeons>> GetCharacterDungeonsAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterDungeonsAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterDungeons>> GetCharacterDungeonsAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterDungeons>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/encounters/dungeons?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterRaids>> GetCharacterRaidsAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterRaidsAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterRaids>> GetCharacterRaidsAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterRaids>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/encounters/raids?namespace={@namespace}&locale={locale}");
        }
    }
}
